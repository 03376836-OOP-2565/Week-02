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
![image](https://user-images.githubusercontent.com/115066414/235313529-d3ad0c8e-ef36-4c15-9488-a66acec0036b.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115066414/235313546-b8abfb82-7ed4-4fcc-8f5b-5a38a6fbb787.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115066414/235313555-6607c3ff-f905-4ffe-952f-3fa09e2089e3.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115066414/235313570-004fb4e9-73e0-465e-bf3b-c413db5fa76d.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115066414/235313586-5e9b787b-edcd-49dc-b108-a287b88fc795.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115066414/235313617-250b4775-dd0b-4ea0-89d0-0822b407dc72.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115066414/235313632-e094b97d-0793-4b81-9474-78b86503bb1b.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115066414/235313644-c554553c-bc42-41da-bfc8-a1802c924cc3.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115066414/235313662-94ea1a45-e80b-486a-b174-e4360f58b2be.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066414/235313676-9f3445b4-4f9e-4959-9668-96e35da0bf3d.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066414/235313696-d6c679d6-707e-41d9-ae5e-5f59d024c0ab.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066414/235313733-3be11a89-18d9-49cf-a2f1-efa4912ef530.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115066414/235313764-1ed9acb2-0c82-4dc4-b911-541c80f7b098.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115066414/235313775-7f695e3c-d9fc-443e-a5f6-0824fd6642ab.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115066414/235313796-21bfdcb6-8f11-4289-b763-dc008a2d50e7.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115066414/235313808-bdb05432-738d-4c68-b5fe-52978d3e7f9b.png)


## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
