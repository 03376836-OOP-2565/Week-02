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
![image](https://user-images.githubusercontent.com/116150760/232725285-7f17dc99-3f15-4aff-b4ea-97dad4411b86.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/116150760/232725543-d932289b-f5ab-4fb1-a248-9b44d3a3b670.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/116150760/232725817-e1675e8e-b480-4ae6-b230-9cac080767ef.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/116150760/232725964-fba45be0-e17e-4997-bd28-79b0d9b4fc17.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/116150760/232726078-3094946e-0928-43e7-9540-607e9ad4034b.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/116150760/232726247-9c6f0f6f-0a1d-4085-95d3-ab8fd44a18d9.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/116150760/232726321-98ec014e-9148-46a9-9ed6-8457a41349be.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/116150760/232726503-b6960118-dab5-4f96-b0a3-de1d90c65e59.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/116150760/232726598-328cf69f-87a7-449d-a68a-df8e31e68d62.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/116150760/232726762-3d8404d8-05dd-4247-b98a-10ca910af4bb.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/116150760/232726900-e90dc519-a78d-4eec-9441-66e24fbc0a52.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/116150760/232727090-d550af7f-48ec-44c4-ab6b-3be2755e4987.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/116150760/232727174-4ba9b8f6-7be1-4d3b-a3b7-9bcf372322ba.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/116150760/232727316-ade3a4f9-d2ee-42a0-b1ea-5a9d05456050.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/116150760/232727399-34a347e7-2f81-4d46-b2a9-8a5811f1b374.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/116150760/232727487-ea340c59-08da-48d0-a14b-be336c9939d5.png)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
