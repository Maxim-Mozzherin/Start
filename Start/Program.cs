Person tom = new Person();  // вызов конструктора
                            // или так 
                            // Person tom = new();

tom.name = "Tom";   // изменяем значение по умолчанию в поле name

tom.Print();    // Имя: Tom  Возраст: 0

struct Person
{
    public string name;
    public int age;

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

/*Если все поля структуры доступны (как в случае с полями структуры Person, который имеют модификатор public), 
 * то структуру можно инициализировать без вызова конструктора. 
 * В этом случае необходимо присвоить значения всем полям структуры перед получением значений полей и обращением к методам структуры. 
 * Например:
 * 
Person tom;         // не вызываем конструктор
// инициализация полей
tom.name = "Sam";
tom.age = 37;
 
tom.Print();    // Имя: Sam  Возраст: 37
 
struct Person
{
    public string name;
    public int age;
 
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
*/

/*Копирование структуры с помощью with
Если нам необходимо скопировать в один объект структуры значения из другого с небольшими изменениями, то мы можем использовать оператор with:
*/

Person tom = new Person { name = "Tom", age = 22 };
Person bob = tom with { name = "Bob" };
bob.Print();    // Имя: Bob  Возраст: 22
//В данном случае объект bob получает все значения объекта tom, а затем после оператора with в фигурных скобках указывается поля со значениями, которые мы хотим изменить.

// Задание для самопроверки:
struct Person
{
    public string name;
}
class Program
{
    static void Main(string[] args)
    {
        Person person;
        Console.WriteLine(person.name);
        person.name = "Bob";
    }
}

// данная программа не скомпилируется, т.к. инициализация поля name происходит после Console.WriteLine(person.name);