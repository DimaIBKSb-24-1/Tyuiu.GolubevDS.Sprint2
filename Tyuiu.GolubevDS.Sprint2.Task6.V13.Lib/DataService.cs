namespace Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task6V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        switch (m)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
                {
                    switch (n)
                    {
                        case 31: n = 1; m++; break;
                        default: n++; break;
                    }
                    break;
                }
            case 2:
                {
                    switch (n)
                    {
                        case 29: n = 1; m++; break;
                        default: n++; break;
                    }
                    break;
                }
            case 4:
            case 6:
            case 9:
            case 11:
                {
                    switch (n)
                    {
                        case 30: n = 1; m++; break;
                        default: n++; break;
                    }
                    break;
                }
            case 12:
                {
                    switch (n)
                    {
                        case 31: n = 1; m = 1; g++; break;
                        default: n++; break;
                    }
                    break;
                }
        }
        string day = n.ToString();
        string month = m.ToString();
        string year = g.ToString();
        return day + '.' + month + '.' + year;
    }
}
