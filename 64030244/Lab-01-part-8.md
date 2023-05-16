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
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/fad760df-c4f2-466d-8a0d-1bdb9351435b)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/3cd03493-51dc-4cef-9f64-fc3cdc813be8)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/b50b55f5-dda6-4997-9887-68e173839a30)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/6d29dea9-3cca-46a8-bdc2-586a01fe7337)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/3216fcf4-dc83-411b-a50a-9243cad3cbc6)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/4ddd7ff7-1db9-44ea-952e-c049ea6bed61)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/d678a128-6f29-4d19-9113-844a466a67c9)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/724a96fe-b99b-4a49-9ba9-34f8fde3bd91)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/e44cbace-8e64-4d76-94fb-321075b6c0b2)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/95895b6f-6300-49de-bf7b-f009e6defd19)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/7f73ab48-2315-4705-b22a-e49b162b7090)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/b9765658-716b-41a8-b653-fffb165c1a43)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/d41f82cc-cbd3-4fdb-8a38-a1dd68aa104f)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/a200ed19-399a-4561-858a-2b2dd81dac99)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/9eb3d0b9-5785-4ad8-8bfe-05506a8bdc0e)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/7b7c82b3-7327-4f08-ab9e-580687578c3f)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
