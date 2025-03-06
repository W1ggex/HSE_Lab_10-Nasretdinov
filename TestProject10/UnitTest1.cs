using System.Diagnostics.Metrics;
using Library10;
using Instrument = System.Diagnostics.Metrics.Instrument;

namespace TestProject10;

public class Tests
{
    /*[SetUp]
    public void Setup()
    {
    } */

    [Test]
    public void Test1()
    {
        //Instrument instrument = new Instrument();
        Assert.AreEqual(true, true);
    } 
}