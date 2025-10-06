using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;
using VokabeltrainerWinForms.Logic;

namespace Vocabulator
{
    public partial class EditorControl : UserControl
    {
        private List<Vocabulary> vocabList;
        private Label lblFeedback;

        public event EventHandler EditsMade;

        public EditorControl()
        {
            InitializeComponent();
            InitializeFeedbackLabel();
            LoadVocab();
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
                Location = new Point(0, btnDelete.Bottom + 10), // Passe ggf. an dein Layout an
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            this.Controls.Add(lblFeedback);
        }

        private void ShowFeedback(string message, bool success)
        {
            lblFeedback.Text = message;
            lblFeedback.ForeColor = success ? Color.Green : Color.Red;
            lblFeedback.Visible = true;

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, e) =>
            {
                lblFeedback.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void LoadVocab()
        {
            vocabList = VocabStorage.LoadVocab();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vocabList.Select(v => new
            {
                v.Spanish,
                v.German,
                v.Phase,
                LastTraining = v.LastReviewed.ToString("dd.MM.yyyy"),
                NextTraining = LeitnerSystem.GetNextReviewDate(v).ToString("dd.MM.yyyy")
            }).ToList();

            dataGridView1.Columns["Spanish"].Width = 120;
            dataGridView1.Columns["German"].Width = 120;
            dataGridView1.Columns["Phase"].Width = 50;
            dataGridView1.Columns["LastTraining"].Width = 90;
            dataGridView1.Columns["NextTraining"].Width = 90;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ShowFeedback("Bitte eine Vokabel auswählen.", false);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            var vocab = vocabList[index];

            var result = MessageBox.Show(
                $"Vokabel '{vocab.Spanish} - {vocab.German}' wirklich löschen?",
                "Löschen bestätigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                vocabList.RemoveAt(index);
                VocabStorage.SaveVocab(vocabList);
                LoadVocab();
                EditsMade?.Invoke(this, EventArgs.Empty);
                ShowFeedback("Vokabel gelöscht.", true);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ShowFeedback("Bitte eine Vokabel auswählen.", false);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            var vocab = vocabList[index];

            string newSpanish = Microsoft.VisualBasic.Interaction.InputBox("Spanisch:", "Bearbeiten", vocab.Spanish);
            string newGerman = Microsoft.VisualBasic.Interaction.InputBox("Deutsch:", "Bearbeiten", vocab.German);

            if (string.IsNullOrWhiteSpace(newSpanish) || string.IsNullOrWhiteSpace(newGerman))
            {
                ShowFeedback("Beide Felder müssen ausgefüllt sein.", false);
                return;
            }

            vocab.Spanish = newSpanish.Trim();
            vocab.German = newGerman.Trim();

            VocabStorage.SaveVocab(vocabList);
            LoadVocab();
            EditsMade?.Invoke(this, EventArgs.Empty);
            ShowFeedback("Vokabel aktualisiert.", true);
        }
    }
}
