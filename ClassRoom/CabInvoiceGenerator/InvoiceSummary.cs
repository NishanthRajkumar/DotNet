namespace CabInvoiceGenerator;

public class InvoiceSummary
{
    private readonly int numberOfRides;
    private readonly double totalFare;
    private readonly double averageFare;
    public InvoiceSummary(int numberOfRides, double totalFare)
    {
        this.numberOfRides = numberOfRides;
        this.totalFare = totalFare;
        this.averageFare = this.totalFare / this.numberOfRides;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        if (obj is not InvoiceSummary)
            return false;
        InvoiceSummary inputObject = (InvoiceSummary)obj;
        return numberOfRides == inputObject.numberOfRides && totalFare == inputObject.totalFare && averageFare == inputObject.averageFare;
    }

    public override int GetHashCode()
    {
        return numberOfRides.GetHashCode() ^ totalFare.GetHashCode() ^ averageFare.GetHashCode();
    }
}
