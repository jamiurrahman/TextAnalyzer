namespace Text_Analyzer
{
    class SimpleCsharpAnalyzer : Analyzer
    {
        public SimpleCsharpAnalyzer() : base(new SimpleCsharpAnalysisStrategy())
        {
            // Do nothing.
        }
    }
}
