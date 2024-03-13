//1. Создайте файл Student и в нём public класс Student.
//2. Добавьте в класс поля, которые считаете нужными, чтобы описать Student.Например, имя, фамилия, возраст, университет, и т.д.
//3. Добавьте в класс метод IntroduceYourself, который был писал в консоль приветствие. Например: "Привет! Меня зовут Егор".
//4. Добавьте в класс конструктор, который принимает аргументы, количество и тип которых соответствует количеству и типу полей класса.
//5. В классе Program создайте массив, состоящий из Student.Наполните его студентами.
//6. Выведите список студентов красиво на экран консоли
//7. Выведите список студентов, старше 21 года на экран консоли.
//8. Выведите на экран консоли самого взрослого и самого младшего студента.

using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;

public class Student
{
    public string name;
    public string soname;
    public int age;
    public string universaty;
    
    static void IntroduceYourself()
    {
        Console.WriteLine("Привет! Меня зовут Егор");
    }
    public Student(int age, string name, string soname, string universaty)
    {
        this.age = age;
        this.name = name;
        this.soname = soname;
        this.universaty = universaty;
    }
    public string Info()
    {
        return this.soname +"   \t  "+ this.name +"   \t  "+ "   Возраст "+ this.age +" лет" + "  \t " + this.universaty + Environment.NewLine;
    }
    public string GetAge() 
    {
        if (this.age > 21)
        {
            return this.soname + "   \t  " + this.name;
        }
        return string.Empty;
    }
}

public class Program
{
    public static void Main()
    {
        Student[] stud = new Student[5];
        stud[0] = new Student(32, "Илья", "Огородников", "УДГУ");
        stud[1] = new Student(21, "Софья", "Гребенкина", "УДГУ");
        stud[2] = new Student(29, "Кирилл", "Корепанов", "ИжГТУ");
        stud[3] = new Student(20, "Алексей", "Шкляев", "УдГАУ");
        stud[4] = new Student(24, "Дмитрий", "Баженов", "ИжГТУ");
        Console.WriteLine("Информация о студентах:");
        Console.WriteLine("ФАМИЛИЯ      \t  ИМЯ     \t     ВОЗРАСТ      \t УЧЕБНОЕ ЗАВЕДЕНИЕ");
        foreach (Student student in stud)
        {
            Console.Write(student.Info());
        }
        //Console.WriteLine();
        Console.WriteLine("\nCписок студентов, старше 21 года:");
        foreach (Student student in stud)
        {
            Console.WriteLine(student.GetAge()); 
        }

        Student minStudent = stud[0];
        Student maxStudent = stud[0];

        foreach (Student student in stud)
        {
            if (student.age < minStudent.age)
            {
                minStudent = student;
            }

            if (student.age > maxStudent.age)
            {
                maxStudent = student;
            }
        }
        Console.WriteLine($"\nСамый молодой студент: {minStudent.name} {minStudent.soname}");
        Console.WriteLine($"\nСамый взрослый студент: {maxStudent.name} {maxStudent.soname}");
    }

}