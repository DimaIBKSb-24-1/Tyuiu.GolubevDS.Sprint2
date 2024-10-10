namespace Tyuiu.GolubevDS.Sprint2.Task4.V29.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task4V29
{
    public double Calculate(double x, double y)
    {
        double z = 0;
        if (x - 3 < y + 2 - 20)
        {
            z = 2 * x + 12 * y - (2 / x);

        }
        else
        {
            z = Math.Pow(x, 2) - (2 / y);
        }
        return Math.Round(z, 3);
    }
}
