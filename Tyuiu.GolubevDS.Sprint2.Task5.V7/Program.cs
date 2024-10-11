using Tyuiu.GolubevDS.Sprint2.Task5.V7.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема : оператор switch                                                  *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | ИБКСб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает значения с клавиатуры и         *");
Console.WriteLine("* вычисляет выражение.                                                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите год: ");
int startYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер месяца: ");
int n = Convert.ToInt32(Console.ReadLine());

string res;

if ((n < 1) || (n > 12))
{
    res = "Введено неверное значение";
}
else
{
    res = "Это месяц " + ds.FindMonthName(startYear, n);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadLine();