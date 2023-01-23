Console.Write("Enter your First name: ");
string fname = Console.ReadLine();
Console.Write("Enter your Last name: ");
string lname = Console.ReadLine();
Console.Write("Enter your ID: ");
Int32 ID = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your GPA: ");
double GPA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("First name : {0}\n" +
    "Last name : {1}\n" +
    "ID : {2}\n" +
    "GPA : {3}", fname, lname, ID, GPA);