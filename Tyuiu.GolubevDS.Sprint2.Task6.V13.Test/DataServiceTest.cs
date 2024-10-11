namespace Tyuiu.GolubevDS.Sprint2.Task6.V13.Test;
using Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindDateOfNextDay()
    {
        DataService ds = new DataService();
        int g = 2024;
        int m = 03;
        int n = 01;
        string expected = "02.03.2024";
        string result = ds.FindDateOfNextDay(g, m, n);

        Assert.AreEqual(expected, result);
    }
}