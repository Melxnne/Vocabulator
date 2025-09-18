namespace VokabeltrainerWinForms
{
    partial class FormEditor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Size = new System.Drawing.Size(400, 200);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 230);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 230);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Löschen";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormEditor
            // 
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Text = "Vokabel Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
