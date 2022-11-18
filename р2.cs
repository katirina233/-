Person aleks = new Person(); 

string personName = aleks.name;
int personAge = aleks.age;
Console.WriteLine($"Имя: {personName}  Возраст {personAge}");  

aleks.name = "Александр";
aleks.age = 23;


aleks.Print();   

class Person
{
    public string name = "Матвей";
    public int age=66;
    public string book = "интересная книга в которой миллион страниц";
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age} Книга:{book}");
    }
}