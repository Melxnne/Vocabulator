using System;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Logic;
using VokabeltrainerWinForms.Utils;

namespace VokabeltrainerWinForms
{
    public partial class FormStart : Form
    {
        private Label lblOverview;

        public FormStart()
        {
            InitializeComponent();
            AddOverview();
            UpdateOverview();
        }

        private void AddOverview()
        {
            lblOverview = new Label();
            lblOverview.Location = new System.Drawing.Point(50, 420); // unter Buttons
            lblOverview.Size = new System.Drawing.Size(220, 70);
            lblOverview.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblOverview.BorderStyle = BorderStyle.FixedSingle; // optional für bessere Sichtbarkeit
            this.Controls.Add(lblOverview);
        }


        private void UpdateOverview()
        {
            var allVocab = VocabStorage.LoadVocab();
            int total = allVocab.Count;
            int dueCount = allVocab.Count(LeitnerSystem.IsDue);
            int totalAttempts = allVocab.Sum(v => v.Attempts);
            int totalErrors = allVocab.Sum(v => v.Errors);
            double errorRate = totalAttempts > 0 ? (double)totalErrors / totalAttempts * 100 : 0;

            lblOverview.Text =
                $"Gesamtvokabeln: {total}\n" +
                $"Fällige Vokabeln: {dueCount}\n" +
                $"Fehlerquote: {errorRate:F1}%";
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            var form = new FormAddWord();
            form.ShowDialog();
            UpdateOverview(); // Übersicht nach Hinzufügen aktualisieren
        }





        private void btnSpanishToGerman_Click(object sender, EventArgs e)
        {
            var form = new FormTraining(true);
            form.ShowDialog();
            UpdateOverview(); // Übersicht nach Training aktualisieren
        }

        private void btnGermanToSpanish_Click(object sender, EventArgs e)
        {
            var form = new FormTraining(false);
            form.ShowDialog();
            UpdateOverview(); // Übersicht nach Training aktualisieren
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var form = new FormStats();
            form.ShowDialog();
            UpdateOverview(); // Übersicht nach Stats öffnen aktualisieren
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            var form = new FormEditor();
            form.ShowDialog();
            UpdateOverview(); // Übersicht nach Editor schließen aktualisieren
        }
    }
}
