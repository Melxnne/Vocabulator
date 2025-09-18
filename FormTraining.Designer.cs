namespace VokabeltrainerWinForms
{
    partial class FormTraining
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label lblPhase;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lblPhase = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblWord
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblWord.Location = new System.Drawing.Point(30, 30);
            this.lblWord.Size = new System.Drawing.Size(320, 40);
            this.lblWord.Text = "Vokabel";

            // txtAnswer
            this.txtAnswer.Location = new System.Drawing.Point(30, 85);
            this.txtAnswer.Width = 320;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(30, 130);
            this.btnCheck.Size = new System.Drawing.Size(140, 40);
            this.btnCheck.Text = "Prüfen";
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // btnShowAnswer
            this.btnShowAnswer.Location = new System.Drawing.Point(210, 130);
            this.btnShowAnswer.Size = new System.Drawing.Size(140, 40);
            this.btnShowAnswer.Text = "Lösung anzeigen";
            this.btnShowAnswer.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnShowAnswer.ForeColor = System.Drawing.Color.White;
            this.btnShowAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);

            // lblPhase
            this.lblPhase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhase.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPhase.Location = new System.Drawing.Point(230, 180);
            this.lblPhase.Size = new System.Drawing.Size(120, 25);
            this.lblPhase.Text = "Phase: 1";
            this.lblPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // FormTraining
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.lblPhase);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Training";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
