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

![image](https://user-images.githubusercontent.com/115066431/235927518-a3d62048-db85-4368-914e-fefc36094b5c.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115066431/235927856-22dbe9ac-1c9b-41bb-bc8f-182869f6841b.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115066431/235928109-69291dcb-e51f-44f0-8251-a760cb002738.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115066431/235928249-3b2a0d7e-7e5f-4787-afde-fcbb787afe37.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115066431/235928379-ae4b75b2-f7c0-485a-9cde-d9b7e69adbb9.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115066431/235928503-5c09273a-4667-4d9c-8285-058163df6b23.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115066431/235928652-0d3ed35f-d8e1-4216-9101-62279aea8265.png)


``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115066431/235928731-3855a855-f0cd-4e73-9943-047c04c9f72c.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115066431/235928836-4110625d-cb3b-4d93-9fa0-a0325313ad46.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066431/235928964-6cb05bc4-2b56-4d56-ae1b-91b8f1eef2a7.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066431/235929138-e90ed654-3dcf-4bb0-bba2-cc20bcd90950.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066431/235929381-a65921aa-670a-4b61-96f7-c17ac4a4bfd9.png)


``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115066431/235929501-f3005ce4-57dc-464d-b1e0-dc28ccacd7fe.png)


``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115066431/235929596-38328629-2bee-44fa-9923-26ad5f37e429.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115066431/235929753-bcb8b187-515d-4abf-a241-e23219c4e2a3.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115066431/235929863-f78521e3-f662-4883-bcdc-6b1fc7b51e21.png)


## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
