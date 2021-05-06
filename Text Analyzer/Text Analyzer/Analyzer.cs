namespace Text_Analyzer
{
    class Analyzer
    {
        private IAnalysisStrategy _analysisStrategy;

        public Analyzer(IAnalysisStrategy analysisStrategy)
        {
            this._analysisStrategy = analysisStrategy;
        }

        public string Analyze(string str)
        {
            return this._analysisStrategy.Analyze(str);
        }
    }
}
