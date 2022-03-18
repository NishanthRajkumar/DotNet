using CabInvoiceGenerator;
using NUnit.Framework;

namespace InvoiceGeneratorTest;

public class Tests
{
    InvoiceGenerator? invoiceGenerator = null;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenDistanceAndTimeShouldReturnTotalFare()
    {
        invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
        double distance = 2.0;
        int time = 5;
        double fare = invoiceGenerator.CalculateFare(distance, time);
        double expected = 25;
        Assert.AreEqual(expected, fare);
    }

    [Test]
    public void GivenMultipleRideShouldReturnInvoiceSummary()
    {
        invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
        Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
        InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
        InvoiceSummary expectedSummary = new InvoiceSummary(2, 35.0);
        //Assert.AreEqual(expectedSummary.GetType(), summary.GetType());
        Assert.AreEqual(summary, expectedSummary);
    }

}
