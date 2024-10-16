﻿using Tyuiu.GolubevDS.Sprint2.Task6.V13.Lib;
DataService ds  = new DataService();

Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                                  *");
Console.WriteLine("* Тема: Получение результата из switch                                                                       *");
Console.WriteLine("* Задание #6                                                                                                 *");
Console.WriteLine("* Вариант #13                                                                                                *");
Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич  | ИБКСб-24-1                                                          *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
Console.WriteLine("* Написать программу, которая использует сокращенный оператор switch и вычисляет требуемое значение и        *");
Console.WriteLine("* возвращает результат.                                                                                      *");
Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(месяц), n(день)         *");
Console.WriteLine("* По заданным g, n и m определить дату следующего дня. Заданный год является високосным.                     *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
Console.WriteLine("**************************************************************************************************************");
Console.WriteLine("Введите год (например, 2023): ");
int g = int.Parse(Console.ReadLine());

Console.WriteLine("Введите месяц (1 - январь, 2 - февраль, и так далее): ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число (01 - 31): ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.FindDateOfNextDay(g, m, n);
Console.WriteLine(result);

Console.ReadKey();