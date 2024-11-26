// Условные конструкции. Практическое задание.
/*
 Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
А программа сранивает два введенных числа и выводит на консоль результат сравнения 
(два числа равны, первое число больше второго или первое число меньше второго).
 */
using System.ComponentModel.Design;

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());



if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number1} меньше чем {number2}");
}
else
{
    Console.WriteLine($"{number1} равно {number2}");
}

/*
Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". 
Иначе программа выводит сообщение "Неизвестное число".
 */

Console.WriteLine("Введите число");
int number =  Convert.ToInt32(Console.ReadLine());

int lowRange = 5;
int highRange = 10;

if (number > lowRange & number < highRange)
    Console.WriteLine("Число больше 5 и меньше 10");
else
    Console.WriteLine("Неизвестное число");

/*
Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
 */

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());

int lowRange3 = 5;
int highRange3 = 10;

if (number3 == lowRange3 | number2 == highRange3)
    Console.WriteLine("Число либо равно 5, либо равно 10");
else
    Console.WriteLine("Неизвестное число");

/*
 В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
Напишите консольную программу, в которую пользователь вводит сумму вклада. 
Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.

Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
 */

Console.WriteLine("Введите сумму вклада");
Double contribution = Convert.ToDouble(Console.ReadLine());

Double interestRateLow = 0.05;
Double interestRateMid = 0.07;
Double interestRateHigh = 0.1;

Double depositLow = 100;
Double depositHigh = 200;

Double result;

if (contribution < depositLow)
{
    result = interestRateLow * contribution + contribution;
    Console.WriteLine("Вклад 5%");
}
else if (contribution >= depositLow && contribution <= depositHigh)
{
    result = interestRateMid * contribution + contribution;
    Console.WriteLine("Вклад 7%");
}
else 
{
    result = interestRateHigh * contribution + contribution;
    Console.WriteLine("Вклад 10%");
}

Console.WriteLine($"Сумма вклада с учетом процентов: {result}");


/*
Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы.
И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы.
Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
 */
static void Main(string[] args)
{
    Console.WriteLine("Введите сумму вклада");
    Double contribution = Convert.ToDouble(Console.ReadLine());

    Double interestRateLow = 0.05;
    Double interestRateMid = 0.07;
    Double interestRateHigh = 0.1;

    Double depositLow = 100;
    Double depositHigh = 200;

    Double result;

    Double bonus = 15;

    if (contribution < depositLow)
    {
        result = interestRateLow * contribution + contribution + bonus;
        Console.WriteLine("Вклад 5%");
    }
    else if (contribution >= depositLow && contribution <= depositHigh)
    {
        result = interestRateMid * contribution + contribution + bonus;
        Console.WriteLine("Вклад 7%");
    }
    else
    {
        result = interestRateHigh * contribution + contribution + bonus;
        Console.WriteLine("Вклад 10%");
    }

    Console.WriteLine($"Вам доступен бонус в размере {bonus} рублей. \nСумма вклада с учетом процентов и бонуса составит : {result} рублей.");
}

/*
 Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 
1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, 
операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции,
и в зависимости от номера операции программа выводит ему название операции.

Для определения операции по введенному номеру используйте конструкцию switch...case.

Если введенное пользователем число не соответствует никакой операции (например, число 120), 
то выведите пользователю сообщение о том, что операция неопределена.
 */

Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
int operationNumber = Convert.ToInt32(Console.ReadLine());
switch (operationNumber)
{
    case 1:
        Console.WriteLine("Сложение");
        break;
    case 2:
        Console.WriteLine("Вычитание");
        break;
    case 3:
        Console.WriteLine("Умножение");
        break;
    default:
        Console.WriteLine("Неизвестная операция");
        break;
}
Console.ReadKey();
/*
 Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, 
и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются).
Результа операции выводиться на консоль.
 */
static void Seven(string[] arrgs)
{
    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
    int operationNumber = Convert.ToInt32(Console.ReadLine());

    int result = 0;
    switch (operationNumber)
    {
        default:
            Console.WriteLine("Неизвестная операция");
            break;
        case 1:
            Console.WriteLine("Сложение");
            result = num1 + num2;
            Console.WriteLine($"Сумма чисел {result}");
            break;
        case 2:
            Console.WriteLine("Вычитание");
            result = num1 - num2;
            Console.WriteLine($"Разность чисел {result}");
            break;
        case 3:
            Console.WriteLine("Умножение");
            result = num1 * num2;
            Console.WriteLine($"Произведение чисел {result}");
            break;

    }
    Console.ReadKey();
}