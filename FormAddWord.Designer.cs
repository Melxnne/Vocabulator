namespace VokabeltrainerWinForms
{
    partial class FormAddWord
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.TextBox txtSpanish;
        private System.Windows.Forms.TextBox txtGerman;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSpanish = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.txtSpanish = new System.Windows.Forms.TextBox();
            this.txtGerman = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Location = new System.Drawing.Point(30, 30);
            this.lblSpanish.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSpanish.Text = "Spanisch:";
            // 
            // txtSpanish
            // 
            this.txtSpanish.Location = new System.Drawing.Point(120, 27);
            this.txtSpanish.Width = 200;
            this.txtSpanish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSpanish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Location = new System.Drawing.Point(30, 70);
            this.lblGerman.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblGerman.Text = "Deutsch:";
            // 
            // txtGerman
            // 
            this.txtGerman.Location = new System.Drawing.Point(120, 67);
            this.txtGerman.Width = 200;
            this.txtGerman.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGerman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 110);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Text = "Hinzufügen";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Türkis
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // FormAddWord
            // 
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.lblSpanish);
            this.Controls.Add(this.txtSpanish);
            this.Controls.Add(this.lblGerman);
            this.Controls.Add(this.txtGerman);
            this.Controls.Add(this.btnSave);
            this.Text = "Vokabel hinzufügen";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
