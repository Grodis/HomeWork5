//1. �������� ���� Student � � �� public ����� Student.
//2. �������� � ����� ����, ������� �������� �������, ����� ������� Student.��������, ���, �������, �������, �����������, � �.�.
//3. �������� � ����� ����� IntroduceYourself, ������� ��� ����� � ������� �����������. ��������: "������! ���� ����� ����".
//4. �������� � ����� �����������, ������� ��������� ���������, ���������� � ��� ������� ������������� ���������� � ���� ����� ������.
//5. � ������ Program �������� ������, ��������� �� Student.��������� ��� ����������.
//6. �������� ������ ��������� ������� �� ����� �������
//7. �������� ������ ���������, ������ 21 ���� �� ����� �������.
//8. �������� �� ����� ������� ������ ��������� � ������ �������� ��������.

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
        Console.WriteLine("������! ���� ����� ����");
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
        return this.soname +"   \t  "+ this.name +"   \t  "+ "   ������� "+ this.age +" ���" + "  \t " + this.universaty + Environment.NewLine;
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
        stud[0] = new Student(32, "����", "�����������", "����");
        stud[1] = new Student(21, "�����", "����������", "����");
        stud[2] = new Student(29, "������", "���������", "�����");
        stud[3] = new Student(20, "�������", "������", "�����");
        stud[4] = new Student(24, "�������", "�������", "�����");
        Console.WriteLine("���������� � ���������:");
        Console.WriteLine("�������      \t  ���     \t     �������      \t ������� ���������");
        foreach (Student student in stud)
        {
            Console.Write(student.Info());
        }
        //Console.WriteLine();
        Console.WriteLine("\nC����� ���������, ������ 21 ����:");
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
        Console.WriteLine($"\n����� ������� �������: {minStudent.name} {minStudent.soname}");
        Console.WriteLine($"\n����� �������� �������: {maxStudent.name} {maxStudent.soname}");
    }

}