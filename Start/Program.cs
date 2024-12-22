// Рекурсивная функция


//Метод для нахождения факториала
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}

int factorial4 = Factorial(4);  // 24
int factorial5 = Factorial(5);  // 120
int factorial6 = Factorial(6);  // 720

Console.WriteLine($"Факториал числа 4 = {factorial4}");
Console.WriteLine($"Факториал числа 5 = {factorial5}");
Console.WriteLine($"Факториал числа 6 = {factorial6}");

/*
 Сначала идет проверка, равно ли число единице:

1
if (n == 1) return 1;
Но вначале n равно 4, поэтому это условие ложно, и соответственно выполняется код

1
return n * Factorial(n - 1);
То есть фактически мы имеем:

1
return 4 * Factorial(3);
Далее выполняется выражение:

1
Factorial(3)
Опять же n не равно 1, поэтому выполняется код

1
return n * Factorial(n - 1);
То есть фактически:

1
return 3 * Factorial(2);
Далее выполняется выражение:

1
Factorial(2)
Опять же n не равно 1, поэтому выполняется код

1
return n * Factorial(n - 1);
То есть фактически:

1
return 2 * Factorial(1);
Далее выполняется выражение:

1
Factorial(1)
Теперь n равно 1, поэтому выполняется код

1
if (n == 1) return 1;
И возвращается 1.

В итоге выражение

1
Factorial(4)
В реальности выливается в

1
4 * 3 * 2 * Factorial(1)
 */

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
int fib1 = Fibonachi(1);
int fib2 = Fibonachi(2);
int fib3 = Fibonachi(3);
int fib4 = Fibonachi(4);
int fib5 = Fibonachi(5);
int fib6 = Fibonachi(6);

Console.WriteLine($"4 число Фибоначчи = {fib1}");
Console.WriteLine($"5 число Фибоначчи = {fib2}");
Console.WriteLine($"6 число Фибоначчи = {fib3}");
Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");



// В статье на метанит не указан, как по мне основной момент, благо есть гпт)) 
// Ваш метод является рекурсивным, поскольку вызывает сам себя до тех пор, пока не выполнится базовое условие (if (n == 1)).
// С этой строкой выше в целом пришло понимание что есть рекурсия