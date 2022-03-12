using IndianStateCensusAnalyzer.DTO;

namespace IndianStateCensusAnalyzer;

internal class IndianCensusAdapter : CensusAdapter
{
    string[] censusData;
    Dictionary<string, CensusDTO> dataMap;
    public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
    {
        dataMap = new Dictionary<string, CensusDTO>();
        censusData = GetCensusData(csvFilePath, dataHeaders);
        foreach (string data in censusData.Skip(1))
        {
            if (!data.Contains(","))
            {
                throw new CensusAnalyserException("File contains wrong delimiter", CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER);

            }
            string[] column = data.Split(",");
            if (csvFilePath.Contains("IndiaStateCode.csv"))
                dataMap.Add(column[1], new CensusDTO(new POCO.StateCodeDAO(column[0], column[1], column[2], column[3])));
            if (csvFilePath.Contains("IndiaStateCensusData.csv"))
                dataMap.Add(column[0], new CensusDTO(new POCO.CensusDataDAO(column[0], column[1], column[2], column[3])));

        }
        return dataMap.ToDictionary(p => p.Key, p => p.Value);
    }
}
