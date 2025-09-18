namespace VokabeltrainerWinForms
{
    partial class FormStart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnSpanishToGerman;
        private System.Windows.Forms.Button btnGermanToSpanish;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnEditor;

        // Neue Labels für Übersicht
        private System.Windows.Forms.Label lblTotalVocab;
        private System.Windows.Forms.Label lblDueVocab;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnSpanishToGerman = new System.Windows.Forms.Button();
            this.btnGermanToSpanish = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();

            this.lblTotalVocab = new System.Windows.Forms.Label();
            this.lblDueVocab = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(50, 20);
            this.btnAddWord.Size = new System.Drawing.Size(220, 60);
            this.btnAddWord.Text = "➕ Vokabel hinzufügen";
            this.btnAddWord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddWord.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAddWord.ForeColor = System.Drawing.Color.White;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWord.FlatAppearance.BorderSize = 0;
            this.btnAddWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);

            // 
            // btnSpanishToGerman
            // 
            this.btnSpanishToGerman.Location = new System.Drawing.Point(50, 100);
            this.btnSpanishToGerman.Size = new System.Drawing.Size(220, 60);
            this.btnSpanishToGerman.Text = "🇪🇸 → 🇩🇪 Üben";
            this.btnSpanishToGerman.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSpanishToGerman.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSpanishToGerman.ForeColor = System.Drawing.Color.White;
            this.btnSpanishToGerman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpanishToGerman.FlatAppearance.BorderSize = 0;
            this.btnSpanishToGerman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSpanishToGerman.Click += new System.EventHandler(this.btnSpanishToGerman_Click);

            // 
            // btnGermanToSpanish
            // 
            this.btnGermanToSpanish.Location = new System.Drawing.Point(50, 180);
            this.btnGermanToSpanish.Size = new System.Drawing.Size(220, 60);
            this.btnGermanToSpanish.Text = "🇩🇪 → 🇪🇸 Üben";
            this.btnGermanToSpanish.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGermanToSpanish.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnGermanToSpanish.ForeColor = System.Drawing.Color.White;
            this.btnGermanToSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGermanToSpanish.FlatAppearance.BorderSize = 0;
            this.btnGermanToSpanish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnGermanToSpanish.Click += new System.EventHandler(this.btnGermanToSpanish_Click);

            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(50, 260);
            this.btnStats.Size = new System.Drawing.Size(220, 60);
            this.btnStats.Text = "📊 Statistik";
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);

            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(50, 340);
            this.btnEditor.Size = new System.Drawing.Size(220, 60);
            this.btnEditor.Text = "📝 Vokabel Editor";
            this.btnEditor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditor.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEditor.ForeColor = System.Drawing.Color.White;
            this.btnEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditor.FlatAppearance.BorderSize = 0;
            this.btnEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);








            // 
            // FormStart
            // 
            this.ClientSize = new System.Drawing.Size(320, 500);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnSpanishToGerman);
            this.Controls.Add(this.btnGermanToSpanish);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnEditor);

            this.Text = "Vokabeltrainer";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }
    }
}
