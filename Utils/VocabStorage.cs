using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using VokabeltrainerWinForms.Models;

namespace VokabeltrainerWinForms.Utils
{
    public static class VocabStorage
    {
        private static string filePath = "Data/vocab.json";

        public static List<Vocabulary> LoadVocab()
        {
            if (!File.Exists(filePath)) return new List<Vocabulary>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Vocabulary>>(json);
        }

        public static void SaveVocab(List<Vocabulary> vocabList)
        {
            Directory.CreateDirectory("Data");
            var json = JsonSerializer.Serialize(vocabList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
