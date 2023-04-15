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
![image](https://user-images.githubusercontent.com/115066359/232008044-2a7bb7ea-7727-4eca-afd1-7c5d4893036f.png)


## ❔ แบบฝึกหัด จงรันโปรแกรมและบันทึกภาพ output ของบรรทัดคำสั่งต่อไปนี้

``` csharp
1. string name = "Hello";
    Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
```
![image](https://user-images.githubusercontent.com/115066359/232008313-c9536b90-0626-487a-9224-04269bc94832.png)

``` csharp
2. Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
```
![image](https://user-images.githubusercontent.com/115066359/232008540-8ea8b4ca-c0a2-463e-8c6c-baa6bb546953.png)

``` csharp
3. Console.WriteLine("Hello " + "World");
```
![image](https://user-images.githubusercontent.com/115066359/232008676-e84c01b0-8d95-4294-b4f1-37b047fea326.png)

``` csharp
4. Console.WriteLine("Here comes a slash \\");
```
![image](https://user-images.githubusercontent.com/115066359/232008794-7b42294b-441c-41ab-ab8a-782ac6752b97.png)

``` csharp
5. Console.WriteLine("|{0, 10}|", 999);
```
![image](https://user-images.githubusercontent.com/115066359/232008939-9850a951-3222-48a9-aac2-8011adc31be1.png)

``` csharp
6. Console.WriteLine("|{0,-10}|", 000);
```
![image](https://user-images.githubusercontent.com/115066359/232009123-fbab3d80-a2fe-4883-946f-58f000c73464.png)

``` csharp
7. Console.WriteLine("The value: {0}.", 500);
```
![image](https://user-images.githubusercontent.com/115066359/232009772-ab7ceb9f-5606-4225-a521-d2260fe36354.png)

``` csharp
8. Console.WriteLine("The value: {0:C}.", 500);
```
![image](https://user-images.githubusercontent.com/115066359/232009855-347a8752-3448-46ac-a1a6-9ed003e316b7.png)

``` csharp
9. Console.WriteLine("{0,-10:F4}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066359/232009949-988be4d9-8511-4786-b9b5-6b4f182c40cc.png)

``` csharp
10. Console.WriteLine("{0,-10:C}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066359/232010048-65124a9d-5114-46ea-8997-6a861954419b.png)

``` csharp
11. Console.WriteLine("{0,-10:E3}", 12.3456789);
```
![image](https://user-images.githubusercontent.com/115066359/232010178-682ff2f9-c350-4dde-9009-7842477bc80d.png)

``` csharp
12. Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
```
![image](https://user-images.githubusercontent.com/115066359/232010305-8f0ac58f-5227-4b1e-9aac-b73f30b7c8b7.png)

``` csharp
13. Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
```
![image](https://user-images.githubusercontent.com/115066359/232010468-57569a81-b202-4724-8522-136f86636e84.png)

``` csharp
14. int i;
    Console.WriteLine("Value\tSquared\tCubed");
    for(i = 1; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
```
![image](https://user-images.githubusercontent.com/115066359/232010596-838ef594-9880-43a1-860e-02c66fd714f8.png)

``` csharp
15. Console.WriteLine("{0:#.###}.", 1234.56789);
```
![image](https://user-images.githubusercontent.com/115066359/232010715-3269cc95-5171-49e5-9cdb-366789cd26b8.png)



## [การใช้งานคำสั่ง Console.Read() และ Console.ReadLine()](./Lab-01-part-9-12.md)
