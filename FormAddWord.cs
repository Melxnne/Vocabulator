using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;

namespace VokabeltrainerWinForms
{
    public partial class FormAddWord : Form
    {
        private List<Vocabulary> vocabList;

        public FormAddWord()
        {
            InitializeComponent();
            vocabList = VocabStorage.LoadVocab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string spanish = txtSpanish.Text.Trim();
            string german = txtGerman.Text.Trim();

            if (string.IsNullOrEmpty(spanish) || string.IsNullOrEmpty(german))
            {
                MessageBox.Show("Bitte beide Felder ausfüllen!");
                return;
            }

            if (vocabList.Any(v => v.Spanish.Equals(spanish, StringComparison.OrdinalIgnoreCase) &&
                                   v.German.Equals(german, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Diese Vokabel existiert bereits!");
                return;
            }

            vocabList.Add(new Vocabulary { Spanish = spanish, German = german });
            VocabStorage.SaveVocab(vocabList);
            MessageBox.Show("Vokabel gespeichert!");
            txtSpanish.Clear();
            txtGerman.Clear();
        }
    }
}
