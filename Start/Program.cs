/*
 Упражнение 1
Задан следующий трехмерный массив:

1
2
3
4
5
int[,,] mas = { { { 1, 2 },{ 3, 4 } }, 
                { { 4, 5 }, { 6, 7 } }, 
                { { 7, 8 }, { 9, 10 } }, 
                { { 10, 11 }, { 12, 13 } }
              };
С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:

{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}
 */

int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
Console.Write("{");
for (int i = 0; i < mas.GetLength(0); i++)
{
    if (i > 0) Console.Write(" , ");
    Console.Write("{");
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (j > 0) Console.Write(" , ");
        Console.Write("{");
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            if (k > 0) Console.Write(" , ");

            Console.Write(mas[i, j, k]);
        }
        Console.Write("}");
    }
    Console.Write("}");
        }
Console.WriteLine("}");

