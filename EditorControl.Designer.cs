namespace Vocabulator
{
    partial class EditorControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        //private Label lblFeedback;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.btnDelete = new Button();
            this.btnEdit = new Button();
            this.lblFeedback = new Label();

            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Size = new System.Drawing.Size(560, 300);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(10, 320);
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.Text = "Löschen";
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(110, 320);
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Cursor = Cursors.Hand;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // lblFeedback
            this.lblFeedback.Location = new System.Drawing.Point(10, 365);
            this.lblFeedback.Size = new System.Drawing.Size(560, 25);
            this.lblFeedback.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            this.lblFeedback.ForeColor = Color.Green;
            this.lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            this.lblFeedback.Visible = false;
            this.lblFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // EditorControl
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblFeedback);
            this.Size = new System.Drawing.Size(580, 400);

            this.ResumeLayout(false);
        }
    }
}
