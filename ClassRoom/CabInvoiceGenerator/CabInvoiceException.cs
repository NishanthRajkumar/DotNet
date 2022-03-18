namespace CabInvoiceGenerator;

public class CabInvoiceException : Exception
{
    public enum ExceptionType
    {
        INVALID_RIDE_TYPE,
        INVALID_DISTANCE,
        INVALID_TIME,
        NULL_RIDES,
        INVALID_USER_ID
    }

    readonly ExceptionType type;
    public CabInvoiceException(ExceptionType type, string message) : base(message)
    {
        this.type = type;
    }
}
