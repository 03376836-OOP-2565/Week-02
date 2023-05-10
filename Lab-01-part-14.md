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
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/f3e5297d-7d48-4082-9ce8-a3d12dddd211)

 
👷 จากจ้อ 14 ให้เขียนโปรแกรมเพื่อสร้างตารางความจริงของลอจิกดังต่อไปนี้

1. `AND`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/378acc11-6562-4542-a88e-7f68c40a362c)

2. `OR`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/1b202724-2bb7-4c5f-9b53-a96b7a0da3f7)
3. `NOT`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/974181cb-3a1c-4012-8c6e-97fd0c4a3860)

4. `NAND`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/03a8728d-5d98-42f5-97c4-61afd8ae7800)

5. `NOR`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/a5242746-3e09-40fb-b13b-f2d66a5fe9d0)

6. `Exclusive OR`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/54b7beef-7b5d-44e5-bde3-f11a47ad8e4e)


## [ชนิดข้อมูลตัวเลขจำนวนเต็ม (Integer Types)](./Lab-01-part-15.md)
