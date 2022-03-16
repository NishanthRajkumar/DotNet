namespace CabInvoiceGenerator;

public class InvoiceSummary
{
    private int numberOfRides;
    private double totalFare;
    private double averageFare;
    public InvoiceSummary(int numberOfRides, double totalFare)
    {
        this.numberOfRides = numberOfRides;
        this.totalFare = totalFare;
        this.averageFare = this.totalFare / this.numberOfRides;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (!(obj is InvoiceSummary)) return false;
        InvoiceSummary inputObject = (InvoiceSummary)obj;
        return this.numberOfRides == inputObject.numberOfRides && this.totalFare == inputObject.totalFare && this.averageFare == inputObject.averageFare;
    }

    public override int GetHashCode()
    {
        return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
    }
}
