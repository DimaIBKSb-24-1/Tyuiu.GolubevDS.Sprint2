namespace Tyuiu.GolubevDS.Sprint2.Task5.V7.Test;
using Tyuiu.GolubevDS.Sprint2.Task5.V7.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindMonthName()
    {
        DataService ds = new DataService();
        Assert.AreEqual("Январь", ds.FindMonthName(1990, 0));
        Assert.AreEqual("Февраль", ds.FindMonthName(1990, 1));
        Assert.AreEqual("Март", ds.FindMonthName(1990, 2));
        Assert.AreEqual("Апрель", ds.FindMonthName(1990, 3));
        Assert.AreEqual("Май", ds.FindMonthName(1990, 4));
        Assert.AreEqual("Июнь", ds.FindMonthName(1990, 5));
        Assert.AreEqual("Июль", ds.FindMonthName(1990, 6));
        Assert.AreEqual("Август", ds.FindMonthName(1990, 7));
        Assert.AreEqual("Сентябрь", ds.FindMonthName(1990, 8));
        Assert.AreEqual("Октябрь", ds.FindMonthName(1990, 9));
        Assert.AreEqual("Ноябрь", ds.FindMonthName(1990, 10));
        Assert.AreEqual("Декабрь", ds.FindMonthName(1990, 11));

        Assert.ThrowsException<ArgumentException>(() =>
        {
            ds.FindMonthName(1990, -1);
        });
        Assert.ThrowsException<ArgumentException>(() =>
        { 
        ds.FindMonthName(1990, 13);
        });
    }
}