using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;  // <--- Wichtig für Text-to-Speech
using System.Windows.Forms;
using VokabeltrainerWinForms.Logic;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;


namespace Vocabulator
{
    public partial class TrainingControl : UserControl
    {
        private List<Vocabulary> vocabList;
        private Vocabulary currentVocab;
        private bool spanishToGerman;
        private Label lblFeedback;
        private SpeechSynthesizer synthesizer;

        public event EventHandler TrainingCompleted;

        public TrainingControl(bool spanishToGerman)
        {
            InitializeComponent();
            this.spanishToGerman = spanishToGerman;

            synthesizer = new SpeechSynthesizer();

            InitializeFeedbackLabel();
            InitializeSpeakButton();

            LeitnerSystem.ResetSession();

            vocabList = VocabStorage.LoadVocab()
                .Where(LeitnerSystem.IsDue)
                .ToList();

            LoadNextWord();
        }

        private void InitializeFeedbackLabel()
        {
            lblFeedback = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                ForeColor = Color.Green,
                Visible = false,
                Width = this.Width,
                Height = 25,
                Location = new Point(0, btnCheck.Bottom + 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            this.Controls.Add(lblFeedback);
        }

        private void InitializeSpeakButton()
        {
            var btnSpeak = new Button
            {
                Text = "🔊 Vorlesen",
                Location = new Point(btnCheck.Right + 10, btnCheck.Top),
                Size = btnCheck.Size,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnSpeak.Click += BtnSpeak_Click;
            this.Controls.Add(btnSpeak);
        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            if (currentVocab == null) return;

            // Nur vorlesen, wenn wir vom Spanischen ins Deutsche übersetzen
            if (!spanishToGerman) return;

            try
            {
                // Hier wird die Stimme fest auf Spanisch (Spanien) gesetzt:
                try
                {
                    synthesizer.SelectVoice("Microsoft Helena Desktop");
                }
                catch { }

                synthesizer.SpeakAsync(currentVocab.Spanish);
            }
            catch (Exception ex)
            {
                ShowFeedback("Fehler beim Vorlesen: " + ex.Message, false);
            }
        }


        private void ShowFeedback(string message, bool success)
        {
            lblFeedback.Text = message;
            lblFeedback.ForeColor = success ? Color.Green : Color.Red;
            lblFeedback.Visible = true;

            var timer = new System.Windows.Forms.Timer
            {
                Interval = 3000
            };
            timer.Tick += (s, e) =>
            {
                lblFeedback.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void LoadNextWord()
        {
            var availableVocab = vocabList
                .Where(v => v.Phase == 1 || !LeitnerSystem.AlreadyUsedInSession(v))
                .ToList();

            if (!availableVocab.Any())
            {
                lblWord.Text = "Keine weiteren Vokabeln fällig!";
                btnCheck.Enabled = false;
                btnShowAnswer.Enabled = false;
                lblPhase.Text = "";
                txtAnswer.Enabled = false;

                ShowFeedback("Training abgeschlossen 🎉", true);
                TrainingCompleted?.Invoke(this, EventArgs.Empty);
                return;
            }

            var rand = new Random();
            currentVocab = availableVocab[rand.Next(availableVocab.Count)];

            lblWord.Text = spanishToGerman ? currentVocab.Spanish : currentVocab.German;
            txtAnswer.Clear();
            txtAnswer.Focus();

            lblPhase.Text = $"Phase: {currentVocab.Phase}";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (currentVocab == null) return;

            string answer = txtAnswer.Text.Trim();
            string correct = spanishToGerman ? currentVocab.German : currentVocab.Spanish;

            if (string.Equals(answer, correct, StringComparison.OrdinalIgnoreCase))
            {
                ShowFeedback("✅ Richtig!", true);
                LeitnerSystem.CorrectAnswer(currentVocab);
                SaveUpdatedVocab();
                LoadNextWord();
            }
            else
            {
                if (currentVocab.Phase == 1)
                {
                    // Bei Phase 1: Erlaube erneuten Versuch
                    ShowFeedback("❌ Falsch – nochmal versuchen?", false);
                    txtAnswer.Clear();
                    return;
                }

                ShowFeedback($"❌ Falsch! Richtige Antwort: {correct}", false);
                LeitnerSystem.WrongAnswer(currentVocab);
                SaveUpdatedVocab();
                LoadNextWord();
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (currentVocab == null) return;

            string correct = spanishToGerman ? currentVocab.German : currentVocab.Spanish;

            ShowFeedback($"💡 Richtige Antwort: {correct}", false);

            LeitnerSystem.WrongAnswer(currentVocab);
            SaveUpdatedVocab();
            LoadNextWord();
        }

        private void SaveUpdatedVocab()
        {
            var allVocab = VocabStorage.LoadVocab();
            var index = allVocab.FindIndex(v => v.Spanish == currentVocab.Spanish && v.German == currentVocab.German);
            if (index >= 0)
            {
                allVocab[index] = currentVocab;
            }
            VocabStorage.SaveVocab(allVocab);
        }
    }
}
