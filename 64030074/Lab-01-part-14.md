# Lab-01 การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ

ตัวแปรชนิด boolean มักจะถูกใช้เป็นที่เก็บผลที่เกิดจากการดำเนินการทางตรรกะ เช่น AND, OR, NOT เป็นต้น ซึ่งการดำเนินการทางตรรกะจะมีตารางความจริง เป็นตัวบอกผลในการดำเนินการของตัวดำเนินการต่างๆ ดังตัวย่าง

### ตัวดำเนินการ AND

Y = A AND B

| A | B | Y |
|---|---|---|
| 0 | 0 | 0 |
| 0 | 1 | 0 |
| 1 | 0 | 0 |
| 1 | 1 | 1 |

### ตัวดำเนินการ OR

Y = A OR B

| A | B | Y |
|---|---|---|
| 0 | 0 | 0 |
| 0 | 1 | 0 |
| 1 | 0 | 0 |
| 1 | 1 | 1 |

### ตัวดำเนินการ NOT

Y = NOT A

| A | Y |
|--|--|
| 0 | 1 |
| 1 | 0 |

ตัวดำเนินการในภาษา C#
ใช้เครื่องหมายต่างๆ ดังต่อไปนี้

| การดำเนินการ | เครื่องหมาย |
|------------|-----------|
| Logical AND | & |
| Logical XOR | ^ |
| Logical OR | \| |

## 14. การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ

ตัวอย่างภาษา C# ต่อไปนี้เป็นการพิมพ์ตารางความจริงออกทางหน้าจอ
👉 ให้เขียนโปรแกรมต่อไปนี้

```csharp
bool A, B,Y;
Console.WriteLine("      Y = A AND B");
Console.WriteLine("-----------------------");
Console.WriteLine("   A      B\t|  Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = A & B;
Console.WriteLine(" {0}\t{1}\t| {2}", A,B,Y);
A = false; B = true; Y = A & B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = A & B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = A & B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115066414/235315084-0900ed7e-80db-47ec-bfff-5f685fd19508.png)

 
👷 จากจ้อ 14 ให้เขียนโปรแกรมเพื่อสร้างตารางความจริงของลอจิกดังต่อไปนี้

1. `AND`
```cs
bool A, B, Y;
Console.WriteLine("      Y = A && B");
Console.WriteLine("-----------------------");
Console.WriteLine("   A      B\t|  Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = A && B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = false; B = true; Y = A && B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = A && B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = A && B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");

```
![image](https://user-images.githubusercontent.com/115066414/235315204-fc901a7d-8395-4887-a3a6-41a3ea025d4a.png)

2. `OR`
```cs
bool A, B, Y;
Console.WriteLine("      Y = A || B");
Console.WriteLine("-----------------------");
Console.WriteLine("   A      B\t|  Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = A || B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = false; B = true; Y = A || B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = A || B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = A || B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");
```
![image](https://user-images.githubusercontent.com/115066414/235315306-bfcdad08-783a-407d-8e6e-52dc8aac503d.png)

3. `NOT`
```cs
bool A, Y;
Console.WriteLine(" Y = not A");
Console.WriteLine("----------------");
Console.WriteLine(" A\t| Y");
Console.WriteLine("----------------");
A = false; Y = !A;
Console.WriteLine(" {0}\t| {1}", A, Y);
A = true; Y = !A;
Console.WriteLine(" {0}\t| {1}", A, Y);
Console.WriteLine("----------------");
```
![image](https://user-images.githubusercontent.com/115066414/235315373-1492a5df-9391-4f08-9a1d-26e49ead29cf.png)

4. `NAND`
```cs
bool A, B, Y;
Console.WriteLine(" Y = NOT(A AND B)");
Console.WriteLine("-----------------------");
Console.WriteLine(" A B\t| Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = !(A && B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = false; B = true; Y = !(A && B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = !(A && B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = !(A && B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");
```
![image](https://user-images.githubusercontent.com/115066414/235315427-eafd63b1-2eb5-451b-b674-0e15a07ffb02.png)

5. `NOR`
```cs
bool A, B, Y;
Console.WriteLine(" Y = !(A || B)");
Console.WriteLine("-----------------------");
Console.WriteLine(" A B\t| Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = !(A || B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = false; B = true; Y = !(A || B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = !(A || B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = !(A || B);
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");
```
![image](https://user-images.githubusercontent.com/115066414/235315497-40acbf82-2012-41fc-babc-6ab5fb19aff7.png)

6. `Exclusive OR`
```cs
bool A, B, Y;
Console.WriteLine(" Y = A ^ B");
Console.WriteLine("-----------------------");
Console.WriteLine(" A B\t| Y");
Console.WriteLine("-----------------------");
A = false; B = false; Y = A ^ B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = false; B = true; Y = A ^ B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = false; Y = A ^ B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
A = true; B = true; Y = A ^ B;
Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
Console.WriteLine("-----------------------");
```
![image](https://user-images.githubusercontent.com/115066414/235315554-8e2178e4-f4f8-4e46-93af-89f91eae19ac.png)

## [ชนิดข้อมูลตัวเลขจำนวนเต็ม (Integer Types)](./Lab-01-part-15.md)
