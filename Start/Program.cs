﻿/*
За каждый месяц банк начисляет к сумме вклада 7% от суммы.
Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

Для вычисления суммы с учетом процентов используйте цикл for. 
Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
*/
Console.WriteLine("Введите сумму");
decimal сontribution = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите количество месяцев");
int countMonths = Convert.ToInt32(Console.ReadLine());
decimal percent = 0.07M;
decimal sum = 0;
decimal сontributionStart = сontribution;
for (int i = 1; i <= countMonths; i++)
{

    сontribution += сontribution * percent;


}
sum = сontribution - сontributionStart;
Console.WriteLine($"Ваш вклад {сontributionStart}руб. на {countMonths} мес.\nВы можете заработать {sum} руб.\n" +
    $"В итоге после {countMonths} мес. сумма вклада составит {сontribution} руб. ");






