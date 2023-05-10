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
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/f6ed9eaf-ec9f-4b44-ba1c-8c147d5212d9)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/0836d232-c1f9-4bd7-9034-a9da7e6240bc)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/b61dbda0-cf33-401e-abca-155681b355a5)

``` csharp
3. Console.WriteLine("Hello " + "World");
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/1b24f3c6-bbcd-4bef-b058-0d3955147ee4)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/76af4c71-52bd-464d-952d-1713d8ce3221)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/62fb59b9-16ea-40e6-909d-3b95f8911dc1)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/fd02686e-faa2-42c0-99bb-a4aa31fddec6)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/d7252d0b-001a-40f5-a7c4-b56a798ed1b1)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/c92bf466-feb4-48dc-903a-a969ba4b14d1)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/b7646732-4958-4a4c-9a4b-f6940ffbc23b)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/48a7c16c-4ce9-42db-afb7-1d1057d65371)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/acee1496-b75d-44d1-af59-c458f1a2a5f0)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/a186f6e9-2c86-4458-a6a9-0836329a3825)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/95c73b74-8973-4c51-8b42-3a09c0b05d6c)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/516b8314-b2e8-4426-89d4-179f2fb2066a)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/c14ee086-568c-4fba-b43c-3e31c3318aae)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
