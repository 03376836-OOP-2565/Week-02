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

![image](https://user-images.githubusercontent.com/115067806/221857405-f955a321-ff74-43eb-88e6-a7fe7216cfe7.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115067806/221857894-581740f4-1f00-4dd9-8cdd-1b1fe208e862.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115067806/221858086-97e5e77b-fda2-486b-ab64-3b416f3b832f.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115067806/221858359-759ea39f-730a-41f9-8081-4120a14d0492.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115067806/221858491-93195dfe-7c02-47f4-9afe-442520d10509.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115067806/221858720-2395eb44-13d4-4500-ba30-f46c93c3e1e3.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115067806/221858828-4746302a-85e4-4df0-9958-42db5d803c35.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115067806/221858953-8c645cc2-01f9-4b01-8cc2-e388ecd5d019.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115067806/221859079-ca330ac0-4726-4a28-bde9-8d533a1e36ca.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115067806/221859195-123ccafe-9723-438e-8c57-93abe85da101.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115067806/221859308-ed0942d3-5839-4339-bcd7-f084bd1e8d1b.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115067806/221859416-b21bad22-2d75-48df-98d3-c7c8c1f2380a.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115067806/221859570-1905f05c-4561-49b9-adb1-1f83241cb6f5.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115067806/221859654-edaa2430-30db-4417-97e1-a81b4c96d250.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115067806/221859783-7a8348f7-5225-4ed4-91dc-c61a920ffcf7.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115067806/221859899-8a712d24-d5aa-4fea-8a61-19566f11061e.png)

## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
