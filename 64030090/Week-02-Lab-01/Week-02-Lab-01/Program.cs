using System;

string n,l;

Console.Write("name:");
n = Console.ReadLine();

Console.Write("Lastname:");
l = Console.ReadLine();

Console.Write("id : ");
int id = Convert.ToInt32(Console.ReadLine());

Console.Write("GPA: : ");
double GPA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{n} {l}\nID={id}\nGPA={GPA}");
Console.ReadKey();