// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");

string firstName = "Ervis";
int age = 20;
double mesatrja = 9.9;

DateTime dateTime = DateTime.Now;
DateTime dateTimeUtc = DateTime.UtcNow;

Console.Write(dateTime);
Console.WriteLine(dateTimeUtc);

for(int i = 0; i < 10; i++)
{
    if(i == 5)
        continue;

    Console.WriteLine("Continue => "+i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break;

    Console.WriteLine("Break => " + i);
}


int[] moshat = new int[] { 10, 24, 30 };
Student[] students = new Student[] {
    new Student() { Id = 1, Name = "Student01"},
    new Student() { Id = 2, Name = "Student02"}
};

for(int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i].Name);
}

List<int> moshatList = new List<int>() { 10, 24, 30 };
List<Student> studentsList = new List<Student>() {
    new Student() { Id = 3, Name = "Student03"},
    new Student() { Id = 4, Name = "Student04"}
};

foreach (var student in studentsList)
{
    Console.WriteLine(student.Name);
}

int AddNumbers(int a, int b)
{
    return a + b;
}

int shuma = AddNumbers(1, 2);
Console.WriteLine("Shuma  ==>>  " + shuma);


var mathHelper = new MathHelper();
var mathHelperShuma = mathHelper.Shuma(2, 4);

var mathHelperStaticShuma = MathHelperStatic.Shuma(2, 4);

Console.WriteLine("Shuma (MathHelper)  ==>>  " + mathHelperShuma);
Console.WriteLine("Shuma (MathHelper)[Sinusi]  ==>>  " + mathHelper.Sinusi(90));
Console.WriteLine("Shuma (MathHelperStatic)  ==>>  " + mathHelperStaticShuma);

string dega = "imi";
Console.WriteLine(dega.ToUpper());
2.Reverse(shuma);

string stop = "";
bool isTrue = false;