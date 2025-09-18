namespace VokabeltrainerWinForms
{
    partial class FormStats
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPhase1, lblPhase2, lblPhase3, lblPhase4, lblPhase5, lblPhase6;
        private System.Windows.Forms.Label lblAttempts, lblErrors, lblErrorRate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPhase1 = new System.Windows.Forms.Label();
            this.lblPhase2 = new System.Windows.Forms.Label();
            this.lblPhase3 = new System.Windows.Forms.Label();
            this.lblPhase4 = new System.Windows.Forms.Label();
            this.lblPhase5 = new System.Windows.Forms.Label();
            this.lblPhase6 = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblErrorRate = new System.Windows.Forms.Label();

            this.SuspendLayout();

            var labels = new[] { lblPhase1, lblPhase2, lblPhase3, lblPhase4, lblPhase5, lblPhase6, lblAttempts, lblErrors, lblErrorRate };
            string[] defaultTexts = { "Phase 1", "Phase 2", "Phase 3", "Phase 4", "Phase 5", "Phase 6", "Gesamtversuche", "Gesamtfehler", "Fehlerquote" };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Location = new System.Drawing.Point(30, 20 + i * 35);
                labels[i].Size = new System.Drawing.Size(300, 30);
                labels[i].Text = defaultTexts[i];
                labels[i].Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                labels[i].ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
                this.Controls.Add(labels[i]);
            }

            // 
            // FormStats
            // 
            this.ClientSize = new System.Drawing.Size(360, 370);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Statistik";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }
    }
}
