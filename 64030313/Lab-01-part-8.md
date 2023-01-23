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
![image](https://user-images.githubusercontent.com/115037574/213534770-2f68cccc-446e-46d5-a14d-850db18c30b5.png)

## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115037574/213535080-cb3355a2-54db-48cc-98a2-f407b2c22e1c.png)
``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115037574/213535336-c49456dd-5175-495d-8bd3-389e48735600.png)
``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115037574/213535505-4b7d665a-0b93-436d-a406-07bbba85587c.png)
``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115037574/213535714-fa93611b-f0bf-437d-9b4e-37dc0908bdfe.png)
``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115037574/213535936-4fefc5d1-2953-4c30-b5b1-4f375b8c4961.png)
``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115037574/213536174-2b993209-d180-4e79-a3a6-3af0a959bdcb.png)
``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115037574/213536404-15f27377-06fb-420c-b1d5-6a55e19728b6.png)
``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115037574/213536652-c87b1f48-6b8d-4ec3-a7d7-b312b0bef5fc.png)
``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115037574/213536946-5553085c-6821-4c2f-a1c3-77fe31ee31a6.png)
``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115037574/213537203-118b227a-b427-4e43-a08c-6664048b909f.png)
``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115037574/213538126-3f1ec1e2-f373-452a-b39b-eee8036a64b8.png)
``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115037574/213538504-82cc4e60-753b-400d-9926-fe1a37346373.png)
``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115037574/213538742-dde6084b-66e9-4788-9c85-3296af89bebe.png)
``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115037574/213539033-0a3d1e76-e729-4475-8a68-900d2de062f2.png)
``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115037574/213539258-db72cc0a-c837-4444-9899-d3aaf79d57fc.png)

## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
