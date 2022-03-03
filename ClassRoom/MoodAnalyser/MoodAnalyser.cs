namespace MoodAnalyserApp;

public class MoodAnalyser
{
    private string message;

    public MoodAnalyser(string message)
    {
        this.message = message;
    }

    public MoodAnalyser()
    {
    }

    public string analyseMood()
    {
        //"null"==""
        //string s = null;

        //string abc = "";
        try
        {   //"null"==""
            if (this.message.Equals(string.Empty))  // ""=="happy"
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
            if (this.message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
        catch (NullReferenceException obj)
        {
            //throw new Exception(obj.Message);

            throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
        }
        return null;
    }
}
