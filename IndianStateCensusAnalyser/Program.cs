using System;

namespace IndianStateCensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string CorrectFilePath = @"C:\Users\CSC\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusData.csv";
           // string FilePath = @"C:\Users\CSC\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCode.csv";
            StateCensusAnalyser state = new StateCensusAnalyser();
            state.CountLines(CorrectFilePath);
        }
    }
}
