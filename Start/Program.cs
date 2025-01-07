using System;
using System.Collections.Generic;
// Здесь объявляется класс Product с полями name, price, quantity, я бы сюда дополнительно добавил еще инициализацию полей и присвоил бы им значения, чтобы не допускать ошибок памяти при работе с переменными и полями класса
class Product
{
    private string name ;
    private double price;
    private int quantity;

    // Конструктор класса, с параметрами string name, double price, int quantity для разграничения параметров и полей класса используется this
    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    // Метод Sell c параметром amount типа int в котором проверяется если amount больше 0 и amount меньше или равен quantity, то quantity -= amount, и вывести на экран остаток
    public void Sell(int amount)
    {
        if (amount > 0 && amount <= quantity)
        {
            quantity -= amount;
            Console.WriteLine($"Продано {amount} шт. {name}. Остаток: {quantity}");
        }
        //Иначе выдать предупреждение, т.к. условие не попадает под текущие значения
        else
        {
            Console.WriteLine("Недостаточно товара на складе или неверное количество.");
        }
    }
    // public метод Restock с параметром amount, где выполняется проверка для amount, если оно больше 0, то добавить к остатку введенное значение, или если введенное значение меньше или =0, то выдать предупреждение
    public void Restock(int amount)
    {
        if (amount > 0)
        {
            quantity += amount;
            Console.WriteLine($"Добавлено {amount} шт. {name}. Теперь на складе: {quantity}");
        }
        else
        {
            Console.WriteLine("Количество для добавления должно быть больше нуля.");
        }
    }
    // public метод DisplayInfo который выводит на дисплей Наименование товара, цену и его количество
    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {name}, Цена: {price}, Количество: {quantity}");
    }
}

// Класс Program, который включает в себя статический метод Main
class Program
{
    static void Main(string[] args)
    {
        // здесь реализован новый экземпляр класса, используются листы, мы добавляем 3 объекта с параметрами name, price, quantity
        List<Product> products = new List<Product>
        {
            new Product("Ноутбук", 50000, 10),
            new Product("Телефон", 30000, 20),
            new Product("Планшет", 20000, 15)
        };
        // цикл While выполнится когда результат вернет true. Выводит список товаров, пока i < products.Count
        while (true)
        {
            Console.WriteLine("\nСписок товаров:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].GetType().Name}");
                products[i].DisplayInfo();
            }

            Console.WriteLine("0. Выход");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > products.Count)
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                continue;
            }
            // если изменение = 0, то прерывает цикл
            if (choice == 0) break;

            Product selectedProduct = products[choice - 1];

            Console.WriteLine("1. Продать товар");
            Console.WriteLine("2. Пополнить товар");
            Console.WriteLine("3. Показать информацию");
            Console.WriteLine("0. Назад");

            int action;
            if (!int.TryParse(Console.ReadLine(), out action) || action < 0 || action > 3)
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                continue;
            }
            // Исключение (пропуск полей, которые = 0)
            if (action == 0) continue;
            // конструкция Switch для того, чтобы пойти по одному пути из трех
            switch (action)
            {
                case 1:
                    Console.Write("Введите количество для продажи: ");
                    int sellAmount;
                    if (int.TryParse(Console.ReadLine(), out sellAmount))
                        selectedProduct.Sell(sellAmount);
                    else
                        Console.WriteLine("Неверный ввод.");
                    break;
                case 2:
                    Console.Write("Введите количество для пополнения: ");
                    int restockAmount;
                    if (int.TryParse(Console.ReadLine(), out restockAmount))
                        selectedProduct.Restock(restockAmount);
                    else
                        Console.WriteLine("Неверный ввод.");
                    break;
                case 3:
                    selectedProduct.DisplayInfo();
                    break;
            }
        }
    }
}
