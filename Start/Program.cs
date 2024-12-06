void Mess(string x, string y) => Console.WriteLine($"{x} + {y} = {x + y}");

Mess("Hi", "dude");    // 10 + 15 = 25


void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

int a = 10, b = 15, c = 6;
Sum(a, b);                  // 10 + 15 = 25
Sum(3, c);                  // 3 + 6 = 9
Sum(14, 4 + c);             // 14 + 10 = 24



/*
Если параметрами метода передаются значения переменных, то таким переменным должно быть присвоено значение.
Например, следующая программа не скомпилируется:
 */
void Sum1(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

int q;
int w = 15;
Sum1(q, w);  // ! Ошибка


/*Соответствие параметов и аргументов по типу данных
При передаче значений параметрам важно учитывать тип параметров: между аргументами и параметрами должно быть соответствие по типу. 
Например:
*/
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

PrintPerson("Tom", 24); // Name: Tom  Age: 24

/*
Необязательные параметры
По умолчанию при вызове метода необходимо предоставить значения для всех его параметров.
Но C# также позволяет использовать необязательные параметры.
Для таких параметров нам необходимо объявить значение по умолчанию. 
Также следует учитывать, что после необязательных параметров все последующие параметры также должны быть необязательными:
*/
void PrintPerson1(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson1("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson1("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
PrintPerson1("Tom");                   // Name: Tom  Age: 1   Company: Undefined


/*
 Именованные параметры
В предыдущих примерах при вызове методов значения для параметров передавались в порядке объявления этих параметров в методе.
То есть аргументы передавались параметрам по позиции. Но мы можем нарушить подобный порядок, используя именованные параметры:
 */

void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
PrintPerson(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google













