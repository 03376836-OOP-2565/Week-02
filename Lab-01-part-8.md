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
![330801904_700538128420862_177725206603350704_n](https://user-images.githubusercontent.com/116150897/221615965-0b9652f4-2a39-4e4e-996f-222a1ee77080.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
  ```![334064258_1885794838446876_8400287826234085367_n](https://user-images.githubusercontent.com/116150897/221620048-1b6b2e77-d3e1-405e-9152-4cddef68e742.png)


``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```![334093473_1254594061827248_8244959549474698297_n](https://user-images.githubusercontent.com/116150897/221619065-4e6dff3d-aa17-40ec-90f0-939f52de34b5.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```![333767249_926993231808741_5425076745899402232_n](https://user-images.githubusercontent.com/116150897/221619108-d742a89c-16d5-485d-b70a-1e65f0397a3b.png)
``` csharp

4. Console.WriteLine("Here comes a slash \\");
```![329558689_536134338504386_1809550580272080147_n](https://user-images.githubusercontent.com/116150897/221619197-a3a35618-f97a-4d9d-8782-f8fdf60a71d1.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```![334067274_970142860817615_3495388946929604097_n](https://user-images.githubusercontent.com/116150897/221619266-d6792a76-a25a-4fbd-a0e6-b8ac36103490.png)

```csharp
6. Console.WriteLine("|{0,-10}|", 000);
```![334021891_547387690535659_5282141499002384588_n](https://user-images.githubusercontent.com/116150897/221619344-e1c2ab70-85f6-4fe8-b620-f2c225d74bc8.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
``` [334043113_103486869353894_5825242084092370767_n](https://user-images.githubusercontent.com/116150897/221619384-54bddc6b-b071-41b0-b500-65ed421518a1.png)


``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```![334049191_503959671890893_5566090269716328264_n](https://user-images.githubusercontent.com/116150897/221619425-e7e12234-690e-4ba1-bd7c-6ad9baed1dd2.png)


``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```![334031915_1172772730093781_776825016549767413_n](https://user-images.githubusercontent.com/116150897/221619457-277901b6-4358-4813-9397-efe9ccb3e30b.png)


``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```![328791785_897281334850950_9013294192896260625_n](https://user-images.githubusercontent.com/116150897/221619486-bad50780-9bfe-44e9-971a-3d53847fec8e.png)


``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```![333979227_1936401566698469_6439800213502076789_n](https://user-images.githubusercontent.com/116150897/221619532-49fa3792-dcaf-4880-8315-ad2d149ebd2a.png)


``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```![333764664_891075518822052_868588972594373864_n](https://user-images.githubusercontent.com/116150897/221619562-4203a6fb-6cc9-4dff-b72c-6116554f3996.png)


``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```![329322342_1899007550449741_431825160824839895_n](https://user-images.githubusercontent.com/116150897/221619586-a297e9f8-b6fe-4de0-a706-e8d7cb71ed67.png)


``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```![328957066_510454427924086_3821668494907272495_n](https://user-images.githubusercontent.com/116150897/221619615-8fc7f163-3772-44c9-98cb-29c46acd713d.png)


``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```![334051195_755775409448336_7482600898737545201_n](https://user-images.githubusercontent.com/116150897/221619639-728ec43a-9c7e-4fc1-85f3-8a62ce20e925.png)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
