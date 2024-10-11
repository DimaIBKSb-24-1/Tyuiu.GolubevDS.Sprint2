namespace Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task6V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        int nextDay;
        int nextMonth;
        int nextYear = g;

        switch (m)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
                if (n < 31)
                {
                    nextDay = n + 01;
                    nextMonth = m;
                }
                else
                {
                    nextDay = 01;
                    nextMonth = m + 01;
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                if (n < 30)
                {
                    nextDay = n + 01;
                    nextMonth = m;
                }
                else
                {
                    nextDay = 01;
                    nextMonth = m + 01;
                }
                break;
            case 12:
                if (n < 31)
                {
                    nextDay = n + 01;
                    nextMonth = m;
                }
                else
                {
                    nextDay = 01;
                    nextMonth = 01;
                    nextYear = g + 01;
                }
                break;
            case 2:
                if (IsLeapYear(g))
                {
                    if (n < 29)
                    {
                        nextDay = n + 01;
                        nextMonth = m;
                    }
                    else
                    {
                        nextDay = 01;
                        nextMonth = m + 01;
                    }
                }
                else
                {
                    if (n < 28)
                    {
                        nextDay = n + 01;
                        nextMonth = m;
                    }
                    else
                    {
                        nextDay = 01;
                        nextMonth = m + 01;
                    }
                }
                break;
            default:
                return "Некорректный номер месяца.";
        }

        return $"Следующая дата: {nextDay}.{nextMonth}.{nextYear}";
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
