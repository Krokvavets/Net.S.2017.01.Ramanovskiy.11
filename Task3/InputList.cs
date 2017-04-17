using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    public class InputList
    {
        public int AllWords { get; private set; }
        /// <summary>
        /// The method creates dictionary with words and count this words
        /// </summary>
        /// <param name="words">input dictionary</param>
        /// <param name="text">input text</param>
        public void CountWordsFrequency(Dictionary<string, int> words, string text)
        {
            if (ReferenceEquals(words, null) || ReferenceEquals(text, null)) throw new ArgumentException("one or bouth args are null");
            const string pattern = @"[А-яЁёA-z]{1,}";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                if (words.ContainsKey(match.Value))
                    words[match.Value]++;
                else
                    words.Add(match.Value, 1);
                AllWords++;
            }
        }
        /// <summary>
        /// The method calculate Frequency of occurrence words.
        /// </summary>
        /// <param name="fileName">Name of file with text</param>
        /// <returns></returns>
        public string Calculate(string fileName)
        {
            if (ReferenceEquals(fileName, null) || fileName == String.Empty || !File.Exists(fileName)) throw new ArgumentException("Invalid name of file");
            var result = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            using (FileStream fs = File.Open(fileName, FileMode.Open))
            {
                var reader = new StreamReader(fs, Encoding.Default);
                string line = reader.ReadToEnd();
                CountWordsFrequency(result, line);
            }
            StringBuilder StringView = new StringBuilder();
            float finishResult = 0;
            foreach (var pair in result)
            {
                finishResult = (float)pair.Value / (float)AllWords;
                StringView.Append(String.Format("{0} : {1},", pair.Key, Math.Round(finishResult, 2)));
            }

            return StringView.ToString();
        }
    }
}
