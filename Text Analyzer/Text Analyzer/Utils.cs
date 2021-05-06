using System.IO;
using System.Text.RegularExpressions;

namespace Text_Analyzer
{
    class Utils
    {
        public static string CleanCharacters(string str)
        {
            str = Regex.Replace(str, @"[^A-Za-z'-]+", " ");
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Replace(str, @"^\s+", "");
            str = Regex.Replace(str, @"\s+$", "");
            //File.WriteAllText("test.txt", str);

            return str;
        }
    }
}
