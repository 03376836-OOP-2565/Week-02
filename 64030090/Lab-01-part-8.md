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
![image](https://user-images.githubusercontent.com/115066356/213693516-dd2f6557-73dc-4324-9cc1-18fb220bb660.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115066356/213694060-847594e6-0187-4ad7-9a74-35c1633f003b.png)


``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115066356/213694376-6dde175f-99cf-4ac9-9ec4-ce36c884c668.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115066356/213694662-156b5027-f821-4522-b18b-16966450f03d.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115066356/213694919-a666b7d2-cef3-4ea8-901b-6ec4cf4aa82a.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115066356/213695177-e9a39e45-7003-4546-beb5-1e9baab1c600.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115066356/213695584-02b59bb5-f950-4640-bb92-29b84ddbdc02.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115066356/213695847-42143334-11ad-430c-9f02-e14b8e05e94a.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115066356/213696125-55050b9e-0d11-4392-814d-1f4bc878cf5a.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066356/213696329-c088e9bb-f2af-4a04-97f6-9a4540143f90.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066356/213696555-bb034915-b305-4dbe-82aa-7fc0752d63d0.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066356/213696803-08d06bca-520e-4aaf-b1d1-4826ae66065c.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115066356/213697048-83e65613-e492-4b82-800b-69751586aef1.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115066356/213697315-4695e6be-2cd8-4dae-a406-e86fdf76f587.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115066356/213697552-7ab537d9-e1bb-43b2-9c23-5863f98c1376.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115066356/213697788-2578f641-fc52-4119-97ff-b6cdcf68c373.png)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
