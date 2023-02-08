# Lab-01  Part 8  การกำหนดรูปแบบพร้อมความกว้างของทศนิยมของอาร์กิวเมนต์

👉 แก้โปรแกรมตามรูปด้านล่างนี้
```csharp
const double i = 123.456789d;
Console.WriteLine("{0:F1}", i);
Console.WriteLine("{0:F2}", i);
Console.WriteLine("{0:F3}", i);
Console.WriteLine("{0:F4}", i);
Console.WriteLine("{0:F5}", i);
```
➢ รันโปรแกรมและบันทึกผล

![ภาพ](https://user-images.githubusercontent.com/115066278/217512553-216864b7-3aad-460c-8975-a7dcdf5c991f.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217512874-40f93ba0-ecf3-47fa-b1eb-5f33a6e3e972.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217512906-f41b93a6-32cb-4e41-aa72-3d20865b4430.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217512950-78a3cab4-dd68-4580-8452-fa00f66a6603.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217512966-0cfcfe5f-4d40-4483-9fab-74465b41cedc.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513004-14811116-0793-407f-ab5b-620ca91f0a90.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513051-3ccfd999-d6e1-45ff-98e2-a61a6c7257d2.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513075-8403f22c-8473-4bd9-97fe-9cfc8db7c840.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513113-6308785c-ce91-442d-9a98-2bd098ff92e5.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513139-0252f444-1a7d-4278-b818-198239abe9e8.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513166-b13b59c2-2cb3-4004-a074-8a6bc5bbd9be.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513202-c93a30d5-ab27-4923-8f22-be0f07f70de2.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513244-50299e7a-1cbe-4b2c-b6fd-db482052a62e.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513289-9abdc862-7508-4304-9e25-c411dbe22669.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513324-88389ec2-81d7-40db-81f1-64514de9bcad.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![ภาพ](https://user-images.githubusercontent.com/115066278/217513359-c8943587-690d-47a2-891a-c9f7b8f0f443.png)


## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
