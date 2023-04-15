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
![image](https://user-images.githubusercontent.com/115066359/232098490-23a1a67a-e803-44c6-9f15-82a27c3f64e3.png)

 
👷 จากจ้อ 14 ให้เขียนโปรแกรมเพื่อสร้างตารางความจริงของลอจิกดังต่อไปนี้

1. `AND`![image](https://user-images.githubusercontent.com/115066359/232098633-1f33f805-5ad4-4d5b-be14-9c22fd9dbcad.png)

2. `OR`![image](https://user-images.githubusercontent.com/115066359/232099131-3bcaf766-bd25-43d0-a158-b606e3a4d6f5.png)

3. `NOT`![image](https://user-images.githubusercontent.com/115066359/232100036-783ca64a-fb92-4dd2-a36a-aeabb5dcfb4a.png)

4. `NAND`![image](https://user-images.githubusercontent.com/115066359/232100668-a906ccd0-dbda-44f4-9a3b-e8b93a02367c.png)

5. `NOR`![image](https://user-images.githubusercontent.com/115066359/232100804-331bd783-f5ba-45d4-b721-6254d95b0cb5.png)

6. `Exclusive OR`![image](https://user-images.githubusercontent.com/115066359/232101227-c5e5f1b9-f7c1-42d8-9efb-e4556142c631.png)



## [ชนิดข้อมูลตัวเลขจำนวนเต็ม (Integer Types)](./Lab-01-part-15.md)
