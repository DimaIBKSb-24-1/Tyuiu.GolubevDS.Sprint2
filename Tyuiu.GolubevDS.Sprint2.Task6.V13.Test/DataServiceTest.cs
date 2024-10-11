namespace Tyuiu.GolubevDS.Sprint2.Task6.V13.Test;
using Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindDateOfNextDay()
    {
        DataService ds = new DataService();
        int g = 2000;
        int m = 12;
        int n = 31;
        string res = ds.FindDateOfNextDay(g, m, n);
        string wait = "1.1.2001";
        Assert.AreEqual(wait, res);
    }
}