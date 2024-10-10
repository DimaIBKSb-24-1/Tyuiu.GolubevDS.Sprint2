namespace Tyuiu.GolubevDS.Sprint2.Task4.V29.Test;
using Tyuiu.GolubevDS.Sprint2.Task4.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondirion1()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 1;
        double res = ds.Calculate(x, y);
        double wait = -1;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondirion2()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 1;
        double res = ds.Calculate(x, y);
        double wait = -1;
        Assert.AreEqual(wait, res);
    }
}