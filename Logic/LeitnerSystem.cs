using System;
using System.Collections.Generic;
using VokabeltrainerWinForms.Models;

namespace VokabeltrainerWinForms.Logic
{
    public static class LeitnerSystem
    {
        private static readonly int[] PhaseIntervals = { 1, 2, 4, 7, 14, 30 };

        // Session-Tracking: Phase>1 Vokabeln, die in dieser Session bereits abgefragt wurden
        private static HashSet<Vocabulary> usedPhaseVocab = new HashSet<Vocabulary>();

        /// <summary>
        /// Prüft, ob eine Vokabel fällig ist (nach Leitner-Intervall)
        /// </summary>
        public static bool IsDue(Vocabulary vocab)
        {
            var nextReview = vocab.LastReviewed.AddDays(PhaseIntervals[vocab.Phase - 1]);
            return DateTime.Now.Date >= nextReview.Date;
        }

        /// <summary>
        /// Wird aufgerufen, wenn die Antwort korrekt war
        /// </summary>
        public static void CorrectAnswer(Vocabulary vocab)
        {
            if (vocab.Phase < 6) vocab.Phase++;
            vocab.LastReviewed = DateTime.Now;
            vocab.Attempts++;

            // Phase>1 nur einmal pro Session abfragen
            if (vocab.Phase > 1)
                usedPhaseVocab.Add(vocab);
        }

        /// <summary>
        /// Wird aufgerufen, wenn die Antwort falsch war
        /// </summary>
        public static void WrongAnswer(Vocabulary vocab)
        {
            vocab.Phase = 1;
            vocab.LastReviewed = DateTime.Now;
            vocab.Attempts++;
            vocab.Errors++;

            // Phase 1 wieder abfragbar → aus Session-Tracking entfernen
            usedPhaseVocab.Remove(vocab);
        }

        public static DateTime GetNextReviewDate(Vocabulary vocab)
        {
            return vocab.LastReviewed.AddDays(PhaseIntervals[vocab.Phase - 1]);
        }

        /// <summary>
        /// Prüft, ob die Vokabel in dieser Session bereits abgefragt wurde
        /// </summary>
        public static bool AlreadyUsedInSession(Vocabulary vocab)
        {
            return vocab.Phase > 1 && usedPhaseVocab.Contains(vocab);
        }

        /// <summary>
        /// Session zurücksetzen (z.B. beim Start einer neuen Trainingsrunde)
        /// </summary>
        public static void ResetSession()
        {
            usedPhaseVocab.Clear();
        }
    }
}
