using System;

namespace VokabeltrainerWinForms.Models
{
    public class Vocabulary
    {
        public string Spanish { get; set; }
        public string German { get; set; }
        public int Phase { get; set; } = 1;
        public DateTime LastReviewed { get; set; } = DateTime.MinValue;
        public int Attempts { get; set; } = 0;
        public int Errors { get; set; } = 0;
    }
}
