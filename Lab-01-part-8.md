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

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/fc6c1a89-0448-41a7-8d19-a2ffb11e70ae)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/5ae7e635-784e-44af-8156-9d81afd1c815)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/1fd0dc12-75f3-4af8-a44f-ec9ac721ca4b)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/d45b7068-9e99-469f-ad9b-d3dd72a91ca5)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/9cf2d2e4-4718-46cb-b4cf-c95f95458927)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/08510b14-9638-4ed9-b711-78d91f60caad)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/ad0f0648-3a63-40ff-91d8-b0c03d088f88)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/ef7f1f1b-66db-44f8-aadb-02c8f69984b7)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/23a196bf-06bd-4ea3-84bf-9c1f9463a80f)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/07de03d6-67b8-489f-ba93-761c6c2f31df)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/1572a2c2-f777-4f32-94d3-126fd7afd97b)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/2242737f-e9f6-4372-85b1-cffbfefb7c51)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/d83a682e-f1eb-4ad4-97a8-e32c9636d312)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/e95f81a5-eff9-404f-b4ee-b97e58649eec)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/4c9edd95-6da9-4cd3-b8c8-6c141637022c)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/e3f42a56-8391-40f0-ae61-59614929891b)


## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
