/*
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


/*
Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
*/
Console.WriteLine("Введите сумму");
decimal сontribution = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите количество месяцев");
int countMonths = Convert.ToInt32(Console.ReadLine());
decimal percent = 0.07M;
decimal sum = 0;
decimal сontributionStart = сontribution;
int i = 1;


while ( i <= countMonths)
{

    сontribution += сontribution * percent;
    i++;

}
sum = сontribution - сontributionStart;
Console.WriteLine($"Ваш вклад {сontributionStart}руб. на {countMonths} мес.\nВы можете заработать {sum} руб.\n" +
    $"В итоге после {countMonths} мес. сумма вклада составит {сontribution} руб. ");


//Напишите программу, которая выводит на консоль таблицу умножения

for (int i = 1; i < 10 ;  i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

/*
 Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10.
Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы,
и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.

Для организации ввода чисел используйте бесконечный цикл while и оператор break.
 */

while (true)
{
    
    Console.WriteLine("Введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
    {
        Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    }
}