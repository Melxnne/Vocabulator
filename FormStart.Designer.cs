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

        private System.Windows.Forms.Label lblOverview; // Für Übersicht

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddWord = new Button();
            btnSpanishToGerman = new Button();
            btnGermanToSpanish = new Button();
            btnStats = new Button();
            btnEditor = new Button();
            lblOverview = new Label();

            SuspendLayout();

            // 
            // btnAddWord
            // 
            btnAddWord.BackColor = Color.FromArgb(52, 152, 219);
            btnAddWord.FlatAppearance.BorderSize = 0;
            btnAddWord.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnAddWord.FlatStyle = FlatStyle.Flat;
            btnAddWord.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddWord.ForeColor = Color.White;
            btnAddWord.Location = new Point(24, 16);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(150, 60);
            btnAddWord.TabIndex = 0;
            btnAddWord.Text = "➕ Vokabel hinzufügen";
            btnAddWord.UseVisualStyleBackColor = false;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // btnSpanishToGerman
            // 
            btnSpanishToGerman.BackColor = Color.FromArgb(46, 204, 113);
            btnSpanishToGerman.FlatAppearance.BorderSize = 0;
            btnSpanishToGerman.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            btnSpanishToGerman.FlatStyle = FlatStyle.Flat;
            btnSpanishToGerman.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSpanishToGerman.ForeColor = Color.White;
            btnSpanishToGerman.Location = new Point(24, 88);
            btnSpanishToGerman.Name = "btnSpanishToGerman";
            btnSpanishToGerman.Size = new Size(150, 60);
            btnSpanishToGerman.TabIndex = 1;
            btnSpanishToGerman.Text = "🇪🇸 → 🇩🇪 Üben";
            btnSpanishToGerman.UseVisualStyleBackColor = false;
            btnSpanishToGerman.Click += btnSpanishToGerman_Click;
            // 
            // btnGermanToSpanish
            // 
            btnGermanToSpanish.BackColor = Color.FromArgb(241, 196, 15);
            btnGermanToSpanish.FlatAppearance.BorderSize = 0;
            btnGermanToSpanish.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 156, 18);
            btnGermanToSpanish.FlatStyle = FlatStyle.Flat;
            btnGermanToSpanish.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGermanToSpanish.ForeColor = Color.White;
            btnGermanToSpanish.Location = new Point(24, 160);
            btnGermanToSpanish.Name = "btnGermanToSpanish";
            btnGermanToSpanish.Size = new Size(150, 60);
            btnGermanToSpanish.TabIndex = 2;
            btnGermanToSpanish.Text = "🇩🇪 → 🇪🇸 Üben";
            btnGermanToSpanish.UseVisualStyleBackColor = false;
            btnGermanToSpanish.Click += btnGermanToSpanish_Click;
            // 
            // btnStats
            // 
            btnStats.BackColor = Color.FromArgb(155, 89, 182);
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 68, 173);
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStats.ForeColor = Color.White;
            btnStats.Location = new Point(24, 232);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(150, 60);
            btnStats.TabIndex = 3;
            btnStats.Text = "📊 Statistik";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // btnEditor
            // 
            btnEditor.BackColor = Color.FromArgb(231, 76, 60);
            btnEditor.FlatAppearance.BorderSize = 0;
            btnEditor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnEditor.FlatStyle = FlatStyle.Flat;
            btnEditor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditor.ForeColor = Color.White;
            btnEditor.Location = new Point(24, 304);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new Size(150, 60);
            btnEditor.TabIndex = 4;
            btnEditor.Text = "📝 Vokabel Editor";
            btnEditor.UseVisualStyleBackColor = false;
            btnEditor.Click += btnEditor_Click;

            // 
            // lblOverview
            // 
            lblOverview.Location = new Point(24, 380);
            lblOverview.Size = new Size(150, 100);
            lblOverview.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblOverview.TextAlign = ContentAlignment.MiddleCenter;
            lblOverview.BorderStyle = BorderStyle.FixedSingle;
            lblOverview.ForeColor = Color.FromArgb(100, 100, 100);
            lblOverview.Text = "Übersicht wird geladen...";
            lblOverview.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // 
            // FormStart
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 500);
            Controls.Add(btnAddWord);
            Controls.Add(btnSpanishToGerman);
            Controls.Add(btnGermanToSpanish);
            Controls.Add(btnStats);
            Controls.Add(btnEditor);
            Controls.Add(lblOverview);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormStart";
            Text = "Vokabeltrainer";
            ResumeLayout(false);
        }
    }
}
