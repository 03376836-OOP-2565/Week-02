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
![image](https://user-images.githubusercontent.com/115066285/232017778-099a1b5e-eb3f-4ebb-b94d-2a0acc9bc399.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
``` ![image](https://user-images.githubusercontent.com/115066285/232019105-ffa095bb-4b62-4434-990f-36d7ee795ce2.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```![image](https://user-images.githubusercontent.com/115066285/232019222-63051ead-6405-46aa-b27e-97b4d1301903.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```![image](https://user-images.githubusercontent.com/115066285/232019605-8ba5eff8-3124-4ec6-84bd-1feafc7b34c7.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```![image](https://user-images.githubusercontent.com/115066285/232021164-3616cbac-c1e3-4b27-9e40-6333e5c71ef6.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```![image](https://user-images.githubusercontent.com/115066285/232023670-e2910203-32d7-4510-8ac9-e7f50dc9ba97.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```![image](https://user-images.githubusercontent.com/115066285/232023993-8c54d1df-0254-4e4e-aafd-5385cb993d69.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```![image](https://user-images.githubusercontent.com/115066285/232024131-0004cec4-cd98-457d-9878-8c83eea98e73.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```![image](https://user-images.githubusercontent.com/115066285/232024234-1a980321-c681-4316-a8b6-5ad252a12fbc.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```![image](https://user-images.githubusercontent.com/115066285/232024363-a3ef99a5-948d-4acc-909e-9986595e0bdf.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```![image](https://user-images.githubusercontent.com/115066285/232024521-0ea001fa-171d-4718-ba9b-f9880490f411.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```![image](https://user-images.githubusercontent.com/115066285/232024634-1e276225-ddbe-43ea-aa0f-51e324b8fe4c.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```![image](https://user-images.githubusercontent.com/115066285/232024785-b4165249-96f4-4f3b-8c97-5c75af1dab74.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```![image](https://user-images.githubusercontent.com/115066285/232024907-80b3c204-e90c-4f10-b710-dd87c80e3022.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```![image](https://user-images.githubusercontent.com/115066285/232025943-22653ae7-6f8e-478a-bd51-c11e127344aa.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```![image](https://user-images.githubusercontent.com/115066285/232033086-2b2def80-010c-433b-84df-1542df3e8054.png)




## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
