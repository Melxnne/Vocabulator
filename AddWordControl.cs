using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;

namespace Vocabulator
{
    public partial class AddWordControl : UserControl
    {
        public event EventHandler VocabChanged;

        private Label lblFeedback;

        public AddWordControl()
        {
            InitializeComponent();
            InitializeFeedbackLabel();
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
                Location = new Point(0, btnSave.Bottom + 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            this.Controls.Add(lblFeedback);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string germanWord = txtGerman.Text.Trim();
            string spanishWord = txtSpanish.Text.Trim();

            if (string.IsNullOrEmpty(germanWord) || string.IsNullOrEmpty(spanishWord))
            {
                ShowFeedback("Bitte fülle beide Felder aus.", false);
                return;
            }

            var allVocab = VocabStorage.LoadVocab();

            bool exists = allVocab.Any(v =>
                string.Equals(v.German, germanWord, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(v.Spanish, spanishWord, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                ShowFeedback("Diese Vokabel existiert bereits.", false);
                return;
            }

            allVocab.Add(new Vocabulary
            {
                German = germanWord,
                Spanish = spanishWord,
                Attempts = 0,
                Errors = 0,
                Phase = 1,
                LastReviewed = DateTime.MinValue
            });

            VocabStorage.SaveVocab(allVocab);

            txtGerman.Text = "";
            txtSpanish.Text = "";

            ShowFeedback("Vokabel hinzugefügt!", true);

            VocabChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ShowFeedback(string message, bool success)
        {
            lblFeedback.Text = message;
            lblFeedback.ForeColor = success ? Color.Green : Color.Red;
            lblFeedback.Visible = true;

            // ✅ Explizit Forms-Timer verwenden
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
    }
}
