using System;
using System.Linq;
using System.Windows.Forms;
using Vocabulator;
using VokabeltrainerWinForms.Logic;
using VokabeltrainerWinForms.Models;
// Alias für VocabStorage, um Mehrdeutigkeitsfehler zu vermeiden
using VocabStorage = VokabeltrainerWinForms.Utils.VocabStorage;

namespace VokabeltrainerWinForms
{
    public partial class FormStart : Form
    {
        //private Label lblOverview;
        private Panel contentPanel;

        public FormStart()
        {
            InitializeComponent();
            InitializeContentPanel();
            //AddOverview();
            UpdateOverview();
        }

        // Panel für Seiteninhalte
        private void InitializeContentPanel()
        {
            contentPanel = new Panel
            {
                Location = new System.Drawing.Point(250, 20),
                Size = new System.Drawing.Size(700, 450), // etwas größer für modernere Optik
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            this.Controls.Add(contentPanel);
        }

        // Lädt ein UserControl in das Panel
        private void LoadPage(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        // Übersichtslabel
        //
         /*
        private void AddOverview()
        {
            lblOverview = new Label
            {
                Location = new System.Drawing.Point(50, 480), // unter Buttons, genug Abstand
                Size = new System.Drawing.Size(180, 70),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            this.Controls.Add(lblOverview);
        }
         */

        // Vokabelübersicht aktualisieren
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

        // Button Click Events (hier keine Änderungen nötig)
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            var control = new AddWordControl();
            control.VocabChanged += (s, args) => UpdateOverview();
            LoadPage(control);
        }

        private void btnSpanishToGerman_Click(object sender, EventArgs e)
        {
            var control = new TrainingControl(true);
            control.TrainingCompleted += (s, args) => UpdateOverview();
            LoadPage(control);
        }

        private void btnGermanToSpanish_Click(object sender, EventArgs e)
        {
            var control = new TrainingControl(false);
            control.TrainingCompleted += (s, args) => UpdateOverview();
            LoadPage(control);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var control = new StatsControl();
            LoadPage(control);
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            var control = new EditorControl();
            control.EditsMade += (s, args) => UpdateOverview();
            LoadPage(control);
        }
    }
}
