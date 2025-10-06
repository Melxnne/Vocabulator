namespace Vocabulator
{
    partial class AddWordControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.TextBox txtGerman;
        private System.Windows.Forms.TextBox txtSpanish;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblGerman = new System.Windows.Forms.Label();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.txtGerman = new System.Windows.Forms.TextBox();
            this.txtSpanish = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblGerman.Location = new System.Drawing.Point(20, 20);
            this.lblGerman.Name = "lblGerman";
            this.lblGerman.Size = new System.Drawing.Size(75, 20);
            this.lblGerman.TabIndex = 0;
            this.lblGerman.Text = "Deutsch:";

            // 
            // txtGerman
            // 
            this.txtGerman.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGerman.Location = new System.Drawing.Point(120, 18);
            this.txtGerman.Name = "txtGerman";
            this.txtGerman.Size = new System.Drawing.Size(220, 27);
            this.txtGerman.TabIndex = 1;

            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblSpanish.Location = new System.Drawing.Point(20, 65);
            this.lblSpanish.Name = "lblSpanish";
            this.lblSpanish.Size = new System.Drawing.Size(74, 20);
            this.lblSpanish.TabIndex = 2;
            this.lblSpanish.Text = "Spanisch:";

            // 
            // txtSpanish
            // 
            this.txtSpanish.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpanish.Location = new System.Drawing.Point(120, 63);
            this.txtSpanish.Name = "txtSpanish";
            this.txtSpanish.Size = new System.Drawing.Size(220, 27);
            this.txtSpanish.TabIndex = 3;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(120, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // AddWordControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGerman);
            this.Controls.Add(this.txtGerman);
            this.Controls.Add(this.lblSpanish);
            this.Controls.Add(this.txtSpanish);
            this.Controls.Add(this.btnSave);

            this.Name = "AddWordControl";
            this.Size = new System.Drawing.Size(370, 160);
        }

        #endregion
    }
}
