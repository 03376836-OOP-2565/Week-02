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

![image](https://github.com/Poramat45/Week-02/assets/115066249/ad216907-e780-4709-89f4-b059a013a247)

## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/424ce238-e5fe-4e7d-804f-d787cbbfb45d)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/2e9f97ea-619a-4e2a-98f9-67329c03ee94)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/94ec0c93-ad64-444c-8643-3002395d1bb1)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/8d0e8dc6-b04c-4fe0-b445-c2934ff29740)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/f3077ecb-f48d-43be-8593-cd746810d94b)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/07b30a57-3603-4370-be91-c660f320186a)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/c2e60941-ae3d-4a5e-8329-cbdb67c5bb86)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/b3017965-264c-41dc-a807-044181d034cd)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/5dfcdcf6-bc1e-467d-85e9-863537f3d000)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/381b49d4-43cc-4b51-9a7a-bbc35555345f)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/4dd5635a-8256-429a-ba93-1598992e8097)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/4569b15f-9584-4e08-acf9-bfd7727ba47a)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/35c4ad70-7dfc-43ed-aba5-06699283a0e7)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/f600a64e-7460-48b1-abf2-6adc5ba2a0c0)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://github.com/Poramat45/Week-02/assets/115066249/76202d02-a4ac-4ff2-873e-f3637a1af38e)

## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
