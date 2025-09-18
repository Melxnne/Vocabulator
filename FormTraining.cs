using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Logic;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;

namespace VokabeltrainerWinForms
{
    public partial class FormTraining : Form
    {
        private List<Vocabulary> vocabList;        // Alle fälligen Vokabeln
        private Vocabulary currentVocab;
        private bool spanishToGerman;

        public FormTraining(bool spanishToGerman)
        {
            InitializeComponent();
            this.spanishToGerman = spanishToGerman;

            // Session zurücksetzen (Phase>1 Tracking)
            LeitnerSystem.ResetSession();

            // Alle Vokabeln laden, die fällig sind
            vocabList = VocabStorage.LoadVocab()
                        .Where(LeitnerSystem.IsDue)
                        .ToList();

            LoadNextWord();
        }

        private void LoadNextWord()
        {
            // Filter für Phase>1: bereits abgefragte Vokabeln in dieser Session nicht erneut
            var availableVocab = vocabList
                .Where(v => v.Phase == 1 || !LeitnerSystem.AlreadyUsedInSession(v))
                .ToList();

            if (!availableVocab.Any())
            {
                lblWord.Text = "Keine weiteren Vokabeln fällig!";
                btnCheck.Enabled = false;
                btnShowAnswer.Enabled = false;
                lblPhase.Text = "";
                return;
            }

            var rand = new Random();
            currentVocab = availableVocab[rand.Next(availableVocab.Count)];

            lblWord.Text = spanishToGerman ? currentVocab.Spanish : currentVocab.German;
            txtAnswer.Clear();

            // Phase unten rechts anzeigen
            lblPhase.Text = $"Phase: {currentVocab.Phase}";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (currentVocab == null) return;

            string answer = txtAnswer.Text.Trim();
            string correct = spanishToGerman ? currentVocab.German : currentVocab.Spanish;

            if (string.Equals(answer, correct, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("✅ Richtig!");
                LeitnerSystem.CorrectAnswer(currentVocab);
                SaveUpdatedVocab();
                LoadNextWord();
            }
            else
            {
                if (currentVocab.Phase == 1)
                {
                    var retry = MessageBox.Show("❌ Falsch! Möchtest du es nochmal versuchen?",
                        "Retry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (retry == DialogResult.Yes)
                    {
                        txtAnswer.Clear();
                        return; // Vokabel erneut eingeben
                    }
                }

                MessageBox.Show($"❌ Falsch! Richtige Antwort: {correct}");
                LeitnerSystem.WrongAnswer(currentVocab);
                SaveUpdatedVocab();
                LoadNextWord();
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (currentVocab == null) return;

            string correct = spanishToGerman ? currentVocab.German : currentVocab.Spanish;
            MessageBox.Show($"Richtige Antwort: {correct}");

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
