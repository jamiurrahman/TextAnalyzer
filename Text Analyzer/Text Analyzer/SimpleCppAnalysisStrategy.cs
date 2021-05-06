using System.Runtime.InteropServices;

namespace Text_Analyzer
{
    class SimpleCppAnalysisStrategy : IAnalysisStrategy
    {
        public const string CppFunctionsDLL = @"..\..\..\Debug\TextAnalyzerFunctionsCpp.dll";

        [DllImport(CppFunctionsDLL, EntryPoint = "GetMaxOccuringWordCpp", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMaxOccuringWordCpp(string str, ResponseDelegate response);

        public delegate void ResponseDelegate(string response);
        public string Analyze(string str)
        {
            string result = "";
            GetMaxOccuringWordCpp(str, response =>
            {
                result = response;
            });

            return result;
        }
    }
}
