namespace Tyuiu.GolubevDS.Sprint2.Task5.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task5V7
{
    public string FindMonthName(int startYear, int n)
    {
        string res;
        switch (n)
        {
            case 0:
                res = "январь";
                break;
                case 1:
                res = "февраль";
                break;
                case 2:
                res = "март";
                break;
                case 3:
                res = "апрель";
                break;
                case 4:
                res = "май";
                break;
                case 5:
                res = "июнь";
                break;
                case 6:
                res = "июль";
                break;
                case 7:
                res = "август";
                break;
                case 8:
                res = "сентябрь";
                break;
                case 9:
                res = "октябрь";
                break;
                case 10:
                res = "ноябрь";
                break;
                case 11:
                res = "декабрь";
                break;
                default :
                throw new ArgumentException($" Месяц должен быть от 1 до 12. Значение {n}");

        }
        return res;
    }
}
