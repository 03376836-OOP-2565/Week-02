# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` | ไม่ได้ | เป็นคำสั่งจึงไม่สามารถนำมาตั้งชื่อตัวแปรได้ |
| `_value` | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `First-name`| ไม่ได้ | Syntax error |
| `Hello!` | ไม่ได้ | ตัวแปรจะต้องไม่มี ! |
| `w*h` | ไม่ได้ | ตัวแปรจะต้องไม่มี * |
| `time` | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `do` | ไม่ได้ | Syntax error |
| `Do` | ใช้ได้| ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `21November`| ไม่ได้ | การตั้งชื่อตัวแปรต้องไม่ขึ้นต้นด้วยตัวเลข|
| `ladkrabang`| ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ  |
| `Student ID`| ไม่ได้ | ไม่ควรตั้งชื่ตัวแปรหลายพยางค์ถ้าจำเป็ยควรเขียนติดกันไม่ควรแยก |


---ผลการทดลอง


## ชนิดข้อมูลภายในภาษา C\#

Property ของชนิดข้อมูล ในภาษา C# มีชนิดข้อมูลต่างๆ ได้แก่ `byte`, `char`, `bool`, `sbyte`, `short`, `ushort`, `int` , `uint`, `float`, `double`, `decimal`, `long`, `ulong` โดยแต่ละชนิด มีคุณสมบัติที่สำคัญได้แก่ ขนาด (เป็นไบต์) ค่าต่ำสุด ค่าสูงสุด ที่เก็บในตัวแปรชนิดนั้นๆ ได้ ซึ่งมีฟังก์ชันในภาษา C# ที่ช่วยให้เราทราบคุณสมบัติเหล่านั้น ได้แก่คำสั่ง `sizeof()`, `MinValue()` และ `MaxValue()` การแสดงค่าคุณสมบัติต่างๆ ของตัวแปร สามารถทำได้โดยใช้ฟังก์ชั่นเหล่านั้น ดังตัวอย่าง

## 13. โปรแกรมแสดงคุณสมบัติ size, MinValue และ MaxValue ของชนิดข้อมูล

```csharp
Console.WriteLine("Data type : int");
Console.WriteLine("Size :" + sizeof(int));
Console.WriteLine("Minimum Value :" + int.MinValue);
Console.WriteLine("Maximum Value :" + int.MaxValue);
```

### ผลที่ได้จากโปรแกรม

```text
Data type : int
Size :4
Minimum Value :-2147483648
Maximum Value :2147483647
```

👉 คำสั่งสำหรับการทดลอง  

ให้นักศึกษา เขียนโปรแกรมคล้ายกับตัวอย่างในข้อ 13 โดยมีชนิดข้อมูลเป็น `byte`, `char`, `bool`, `sbyte`, `short`, `ushort`, `uint`, `float`, `double`, `decimal`, `long` `และ ulong`  

### หมายเหตุ

ชนิดข้อมูล bool เก็บข้อมูลได้เฉพาะ true และ false ไม่ต้องหา MinValue และ MaxValue

ชนิดข้อมูล char จะต้องมีการ cast ค่า MinValue และ MaxValue ไปยัง int ก่อน ดังนี้

```csharp
Console.WriteLine("Minimum Value :" + (int) char.MinValue);
Console.WriteLine("Maximum Value :" + (int) char.MaxValue);
```
---ผลการทดลอง `char`
![image](https://user-images.githubusercontent.com/115066356/213755810-11fc2345-8ab6-4e1b-88ba-cd884ac9d634.png)

---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/115066356/213755379-c5752cfd-1d43-45b1-8fa0-6afeacbd9ae7.png)


---ผลการทดลอง `short`
 ![image](https://user-images.githubusercontent.com/115066356/213756199-096d7b7d-b797-43be-803f-38f729491218.png)


---ผลการทดลอง `ushort`
![image](https://user-images.githubusercontent.com/115066356/213756445-90235036-13c7-4261-a94d-20135ee556fc.png)

 

---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/115066356/213756931-a42ba814-4394-4297-b2fa-dfd098a617c8.png)

 

---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/115066356/213757445-d92fe371-71de-4c85-af8d-92262560b95c.png)


---ผลการทดลอง `double`
 ![image](https://user-images.githubusercontent.com/115066356/213757844-cfb95015-a087-42a5-b4dd-05ab43b8f0c3.png)

---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/115066356/213758431-40361830-b35c-454d-a7b4-9743f3a7fedb.png)

---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/115066356/213759168-871cd8e2-009f-473b-8648-675254461aee.png)


---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/115066356/213759612-a21f92cc-a489-4623-8b24-c570ba0b8ff3.png)


---ผลการทดลอง `bool`

![image](https://user-images.githubusercontent.com/115066356/213760227-5ce1e423-765d-4780-a10c-9976a934ddf6.png)

---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/115066356/213760530-f32051ee-d210-4d71-844a-c5a1a6b4e014.png)


## การใช้งานข้อมูลชนิดต่างๆ

ข้อมูลชนิดตรรกะ The Boolean Type
ข้อมูลชนิดตรรกะ (boolean) มีค่าที่เป็นไปได้เพียง 2 ค่าเท่านั้นคือ true และ false ในภาษา C# จะไม่สามารถกำหนดค่าตัวเลขลงไปในตัวแปร boolean ได้ ส่วนใหญ่ตัวแปร boolean มักใช้เพื่อการตัดสินใจและมีที่มาจากการประเมินค่าสมการต่างๆ ตัวอย่างต่อไปนี้เป็นการใช้ตัวแปร boolean กับการเปรียบเทียบด้วยตัวดำเนินการ “>”
ตัวอย่าง

```csharp
bool a = 4 > 5;
Console.WriteLine("4 > 5 is {0}", a);
```

## สนุกกับการสร้างตัวเลขสุ่ม

ในภาษา C# มีวิธีการสร้างตัวเลขสุ่ม (random number) โดยใช้คลาส Random มาสร้างเป็นตัวแปรโดยมีรูปแบบดังนี้

```csharp
Random random = new Random();
```

เมื่อสร้างแล้ว เราสามารถนำมาหาค่าตัวเลขสุ่มจากตัวแปรดังกล่าว ซึ่งมักจะกำหนดค่าสูงสุดและต่ำสุดในการสุ่มลงไปด้วย ดังนี้

```csharp
int randomNumber = random.Next(0, 100);
```

โปรแกรมด้านล่างนี้เป็นตัวอย่างการสุ่มเลข 0 – 100

```csharp
Random random = new Random();
int randomNumber = random.Next(0, 100);
Console.WriteLine(randomNumber);
```
 
ให้รัน 10 ครั้งแล้วบันทึกค่าที่ได้จากการรัน

## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
