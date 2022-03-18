namespace CabInvoiceGenerator;

public class InvoiceGenerator
{
    readonly RideType rideType;
    private readonly RideRepository rideRepository;
    private readonly double MINIMUM_COST_PER_KM;
    private readonly int COST_PER_TIME;
    private readonly double MINIMUM_FARE;

    public InvoiceGenerator(RideType rideType)
    {
        this.rideType = rideType;
        rideRepository = new RideRepository();
        try
        {
            if (rideType == RideType.PREMIUM)
            {
                MINIMUM_COST_PER_KM = 15;
                COST_PER_TIME = 2;
                MINIMUM_FARE = 20;
            }
            else if (rideType == RideType.NORMAL)
            {
                MINIMUM_COST_PER_KM = 10;
                COST_PER_TIME = 1;
                MINIMUM_FARE = 5;
            }

        }
        catch (CabInvoiceException)
        {
            throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid ride type");
        }
    }

    public double CalculateFare(double distance, int time)
    {
        double totalFare = 0;
        try
        {
            totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
        }
        catch (CabInvoiceException)
        {
            if (rideType.Equals(null))
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid ride type");
            if (distance <= 0)
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid distance");
            if (time < 0)
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid time");
        }
        return Math.Max(totalFare, MINIMUM_FARE);
    }


    public InvoiceSummary CalculateFare(Ride[] rides)
    {
        double totalFare = 0;
        try
        {
            foreach (Ride ride in rides)
                totalFare += CalculateFare(ride.distance, ride.time);
        }
        catch (CabInvoiceException)
        {
            if (rides == null)
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "rides are null");
        }
        return new InvoiceSummary(rides.Length, totalFare);
    }

    public InvoiceSummary GetInvoiceSummary(String userId)
    {
        try
        {
            return CalculateFare(rideRepository.getRides(userId));
        }
        catch (CabInvoiceException)
        {
            throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user id");
        }
    }
}
