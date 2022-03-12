namespace IndianStateCensusAnalyzer;

public class CensusAdapter
{
    protected string[] GetCensusData(string csvFilePath, string dataHeaders)
    {
        string[] censusData;
        if (!File.Exists(csvFilePath))
        {
            throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
        }
        if (Path.GetExtension(csvFilePath) != ".csv")
        {
            throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
        }
        censusData = File.ReadAllLines(csvFilePath);
        if (censusData[0] != dataHeaders)
        {
            throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
        }
        return censusData;
    }
}
