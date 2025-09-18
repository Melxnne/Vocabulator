using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;
using VokabeltrainerWinForms.Logic;

namespace VokabeltrainerWinForms
{
    public partial class FormEditor : Form
    {
        private List<Vocabulary> vocabList;

        public FormEditor()
        {
            InitializeComponent();
            LoadVocab();
        }

        private void LoadVocab()
        {
            vocabList = VocabStorage.LoadVocab();

            // Datenquelle für DataGridView inkl. Letztes und nächstes Training
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vocabList.Select(v => new
            {
                v.Spanish,
                v.German,
                v.Phase,
                LastTraining = v.LastReviewed.ToString("dd.MM.yyyy"),
                NextTraining = LeitnerSystem.GetNextReviewDate(v).ToString("dd.MM.yyyy")
            }).ToList();

            // Optional: Spaltenbreiten anpassen
            dataGridView1.Columns["Spanish"].Width = 120;
            dataGridView1.Columns["German"].Width = 120;
            dataGridView1.Columns["Phase"].Width = 50;
            dataGridView1.Columns["LastTraining"].Width = 90;
            dataGridView1.Columns["NextTraining"].Width = 90;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int index = dataGridView1.CurrentRow.Index;
            var vocab = vocabList[index];

            var confirm = MessageBox.Show($"Vokabel '{vocab.Spanish} - {vocab.German}' wirklich löschen?",
                "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                vocabList.RemoveAt(index);
                VocabStorage.SaveVocab(vocabList);
                LoadVocab();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int index = dataGridView1.CurrentRow.Index;
            var vocab = vocabList[index];

            string newSpanish = Microsoft.VisualBasic.Interaction.InputBox("Spanisch:", "Bearbeiten", vocab.Spanish);
            string newGerman = Microsoft.VisualBasic.Interaction.InputBox("Deutsch:", "Bearbeiten", vocab.German);

            if (!string.IsNullOrWhiteSpace(newSpanish) && !string.IsNullOrWhiteSpace(newGerman))
            {
                vocab.Spanish = newSpanish;
                vocab.German = newGerman;
                VocabStorage.SaveVocab(vocabList);
                LoadVocab();
            }
        }
    }
}
