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

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/06f81b01-e43a-42d6-a9b2-c6d74f4fab75)

 
👷 จากจ้อ 14 ให้เขียนโปรแกรมเพื่อสร้างตารางความจริงของลอจิกดังต่อไปนี้

1. `AND` 

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/ae10c569-9ca3-47ae-92f2-f81a08d746b4)

2. `OR` 

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/6c535108-08d1-48b4-8906-e8b020d98ee9)

3. `NOT` 

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/4a027ca5-b3e5-4c5f-817a-4c2d72b6cc16)

4. `NAND` 

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/157cc013-d8e8-4bfe-9da1-aebe79430c90)

5. `NOR`

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/00d11090-b16d-4645-8c22-d26e5fa26492)

6. `Exclusive OR`

![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/9eb9a3db-d4b4-42a0-b012-ce2cc36f9f15)



## [ชนิดข้อมูลตัวเลขจำนวนเต็ม (Integer Types)](./Lab-01-part-15.md)
