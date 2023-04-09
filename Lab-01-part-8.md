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
![Screenshot 2023-04-09 162434](https://user-images.githubusercontent.com/115066186/230765173-6ff97dd9-1d60-4ca1-a111-d558b583930b.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
``` csharp
3. Console.WriteLine("Hello " + "World");
```
``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![Screenshot 2023-04-09 161336](https://user-images.githubusercontent.com/115066186/230765070-bd6df374-9f87-4497-a863-1c5621652f7f.png)
![Screenshot 2023-04-09 161407](https://user-images.githubusercontent.com/115066186/230765074-a429f759-bccd-404d-af81-de4dcb35502c.png)
![Screenshot 2023-04-09 161436](https://user-images.githubusercontent.com/115066186/230765075-2e2f18d0-5662-4b5a-93a0-67d9f318e46c.png)
![Screenshot 2023-04-09 161454](https://user-images.githubusercontent.com/115066186/230765076-1fe183ba-ecba-4fae-b7cc-9104d95862bb.png)
![Screenshot 2023-04-09 161626](https://user-images.githubusercontent.com/115066186/230765078-882d5eaa-08da-4e2c-99ce-80ab51d8821e.png)
![Screenshot 2023-04-09 161648](https://user-images.githubusercontent.com/115066186/230765080-87e3f44b-fa52-4922-ac95-274e85409079.png)
![Screenshot 2023-04-09 161707](https://user-images.githubusercontent.com/115066186/230765082-b43b1720-88ec-444a-8089-191bb750cbee.png)
![Screenshot 2023-04-09 161727](https://user-images.githubusercontent.com/115066186/230765084-e70bf27c-9408-4e3c-b0ca-8c2340956957.png)
![Screenshot 2023-04-09 161758](https://user-images.githubusercontent.com/115066186/230765085-6d72b9b8-052c-4588-b224-92f7c34c197d.png)
![Screenshot 2023-04-09 161819](https://user-images.githubusercontent.com/115066186/230765087-f0135e80-8c16-4fce-9abc-01af17ee592e.png)
![Screenshot 2023-04-09 161838](https://user-images.githubusercontent.com/115066186/230765090-16c4d211-4c32-435c-912f-162dcae0164b.png)
![Screenshot 2023-04-09 161855](https://user-images.githubusercontent.com/115066186/230765093-4a7277d5-e1dd-43b4-997f-310e6b97e077.png)
![Screenshot 2023-04-09 161911](https://user-images.githubusercontent.com/115066186/230765095-9c11c8c5-f9fa-42ef-9ee9-d22cd0c21d6b.png)
![Screenshot 2023-04-09 161937](https://user-images.githubusercontent.com/115066186/230765097-eb1a8b83-3233-46b7-9f4e-640ae0592452.png)
![Screenshot 2023-04-09 162001](https://user-images.githubusercontent.com/115066186/230765099-f31f3393-c785-4d2c-912a-63349ec8965f.png)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
