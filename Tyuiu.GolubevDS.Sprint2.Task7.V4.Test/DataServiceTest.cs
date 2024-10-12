namespace Tyuiu.GolubevDS.Sprint2.Task7.V4.Test;
using Tyuiu.GolubevDS.Sprint2.Task7.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();
         double x = 1;
        double y = 1;

        bool res = ds.CheckDotInShadedArea(x, y);

        bool wait = false;
        Assert.AreEqual(wait, res);

    }
}