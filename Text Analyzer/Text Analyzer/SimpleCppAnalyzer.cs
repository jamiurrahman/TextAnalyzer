namespace Text_Analyzer
{
    class SimpleCppAnalyzer : Analyzer
    {
        public SimpleCppAnalyzer() : base(new SimpleCppAnalysisStrategy())
        {
            // Do nothing.
        }
    }
}
