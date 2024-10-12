namespace Tyuiu.GolubevDS.Sprint2.Task7.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V4
{
    public bool CheckDotInShadedArea(double x, double y)
    {
        bool res;
        if ((x >= -1) && (x < 0) && (x >= 0.3) && (x <= 1) && (y > 0) && (y < 0.3) && (y > 0.3) && (y < 1))
        {
            res = true;

        }
        else
        {
            res = false;
        }
        return res;
    }
}
