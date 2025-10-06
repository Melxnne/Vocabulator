using System;
using System.Linq;
using System.Windows.Forms;
//using Vocabulator.Models;     // Falls dein Vokabel-Modell hier liegt
//using Vocabulator.Utils;      // Falls dein VocabStorage hier liegt
using VokabeltrainerWinForms.Logic;
using VokabeltrainerWinForms.Models;
using VokabeltrainerWinForms.Utils;

namespace Vocabulator
{
    public partial class StatsControl : UserControl
    {
        public StatsControl()
        {
            InitializeComponent();
            LoadStats(); // Wichtig: Aufruf der Statistikberechnung
        }

        private void LoadStats()
        {
            var vocabList = VocabStorage.LoadVocab();  // Holt Vokabeln
            int[] phaseCounts = new int[6];
            int totalAttempts = vocabList.Sum(v => v.Attempts);
            int totalErrors = vocabList.Sum(v => v.Errors);

            foreach (var v in vocabList)
                phaseCounts[v.Phase - 1]++;

            lblPhase1.Text = $"Phase 1: {phaseCounts[0]}";
            lblPhase2.Text = $"Phase 2: {phaseCounts[1]}";
            lblPhase3.Text = $"Phase 3: {phaseCounts[2]}";
            lblPhase4.Text = $"Phase 4: {phaseCounts[3]}";
            lblPhase5.Text = $"Phase 5: {phaseCounts[4]}";
            lblPhase6.Text = $"Phase 6: {phaseCounts[5]}";

            lblAttempts.Text = $"Gesamtversuche: {totalAttempts}";
            lblErrors.Text = $"Gesamtfehler: {totalErrors}";
            lblErrorRate.Text = totalAttempts > 0
                ? $"Fehlerquote: {((double)totalErrors / totalAttempts * 100):F1}%"
                : "Fehlerquote: 0%";
        }
    }
}
