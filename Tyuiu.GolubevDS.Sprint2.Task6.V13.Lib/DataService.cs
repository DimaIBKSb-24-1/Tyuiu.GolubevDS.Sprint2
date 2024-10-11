namespace Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task6V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        if (g <= 0 || m < 1 || m > 12 || n < 1 || n > 31)
        {
            throw new ArgumentException("Некорректная дата.");
        }

        
        int[] daysInMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        
        if (n > daysInMonth[m])
        {
            throw new ArgumentException("Некорректная дата.");
        }

        
        n++;

        
        if (n > daysInMonth[m])
        {
            n = 1;
            m++;

            
            if (m > 12)
            {
                m = 1;
                g++;
            }
        }

     
        return $"{n:D2}.{m:D2}.{g}";
    }
}

