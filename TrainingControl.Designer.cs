namespace Vocabulator
{
    partial class TrainingControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWord;
        private Label lblPhase;
        private TextBox txtAnswer;
        private Button btnCheck;
        private Button btnShowAnswer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWord = new Label();
            this.lblPhase = new Label();
            this.txtAnswer = new TextBox();
            this.btnCheck = new Button();
            this.btnShowAnswer = new Button();

            this.SuspendLayout();

            // lblWord
            this.lblWord.Location = new System.Drawing.Point(20, 15);
            this.lblWord.Size = new System.Drawing.Size(310, 35);
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblPhase
            this.lblPhase.Location = new System.Drawing.Point(340, 15);
            this.lblPhase.Size = new System.Drawing.Size(90, 35);
            this.lblPhase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhase.ForeColor = System.Drawing.Color.Gray;
            this.lblPhase.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // txtAnswer
            this.txtAnswer.Location = new System.Drawing.Point(20, 65);
            this.txtAnswer.Size = new System.Drawing.Size(310, 30);
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(20, 110);
            this.btnCheck.Size = new System.Drawing.Size(130, 40);
            this.btnCheck.Text = "Check";
            this.btnCheck.FlatStyle = FlatStyle.Flat;
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Cursor = Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // btnShowAnswer
            this.btnShowAnswer.Location = new System.Drawing.Point(180, 110);
            this.btnShowAnswer.Size = new System.Drawing.Size(150, 40);
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.FlatStyle = FlatStyle.Flat;
            this.btnShowAnswer.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnShowAnswer.ForeColor = System.Drawing.Color.White;
            this.btnShowAnswer.Cursor = Cursors.Hand;
            this.btnShowAnswer.FlatAppearance.BorderSize = 0;
            this.btnShowAnswer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);

            // TrainingControl
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnShowAnswer);
            this.Size = new System.Drawing.Size(450, 170);
            this.MinimumSize = new System.Drawing.Size(450, 170);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
