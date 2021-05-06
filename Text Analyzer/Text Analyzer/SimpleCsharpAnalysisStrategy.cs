using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Text_Analyzer
{
    class SimpleCsharpAnalysisStrategy : IAnalysisStrategy
    {
        public string Analyze(string str)
        {
            string result = "";
            Dictionary<string, int> dictionaryWords = new Dictionary<string, int>();

            string pattern = @"\W|_";
            string[] words = Regex.Split(str, pattern);

            foreach (var word in words)
            {
                if (word == "")
                {
                    continue;
                }

                if (dictionaryWords.ContainsKey(word))
                {
                    dictionaryWords[word] += 1;
                }
                else
                {
                    dictionaryWords.Add(word, 1);
                }
            }

            int max = int.MinValue;
            foreach (var key in dictionaryWords.Keys)
            {
                if (dictionaryWords[key] > max)
                {
                    max = dictionaryWords[key];
                    result = key + " => " + dictionaryWords[key];
                }
            }

            return result;
        }
    }
}
