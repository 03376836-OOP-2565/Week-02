# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` | | |
| `_value` | | |
| `First-name`| | |
| `Hello!` | | |
| `w*h` | | |
| `time` | | |
| `do` | | |
| `Do` | | |
| `21November`| | |
| `ladkrabang`| | |
| `Student ID`| | |


---ผลการทดลอง

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` |ใช้ไม่ได้    |เป็นคำสงวนในภาษา C# |
| `_value` |ใช้ได้|ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ  |
| `First-name`|ใช้ไม่ได้    |ตัวแปรจะต้องไม่ประกอบไปด้วยอักษรพิเศษทุกชนิด |
| `Hello!` |ใช้ไม่ได้    |ตัวแปรจะต้องไม่ประกอบไปด้วยอักษรพิเศษทุกชนิด |
| `w*h` |ใช้ไม่ได้    |ตัวแปรจะต้องไม่ประกอบไปด้วยอักษรพิเศษทุกชนิด  |
| `time` |ใช้ได้    |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `do` |ใช้ไม่ได้    |เป็นคำสงวนในภาษา C# |
| `Do` |ใช้ได้    |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `21November`|ใช้ไม่ได้    |ละเมิดกฎการตั้งชื่อ |
| `ladkrabang`|ใช้ได้    |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Student ID`|ใช้ได้    |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |

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

![image](https://user-images.githubusercontent.com/115066431/235935333-8f206129-e398-4b33-b4de-86df6cb445e6.png)


---ผลการทดลอง `byte`

![image](https://user-images.githubusercontent.com/115066431/235935437-27c92e75-a17a-4d9b-98fc-d6a30c0aece2.png)


---ผลการทดลอง `short`
 
![image](https://user-images.githubusercontent.com/115066431/235935600-a10b19de-490f-4fbf-a4f8-0dc2292e81da.png)


---ผลการทดลอง `ushort`

 ![image](https://user-images.githubusercontent.com/115066431/235935838-0a363b88-6670-41dd-b425-f90518d441fd.png)


---ผลการทดลอง `uint`

![image](https://user-images.githubusercontent.com/115066431/235936926-aa3f807c-9961-4e9c-bdb0-6e274a6ca1a3.png)

 

---ผลการทดลอง `float`

 ![image](https://user-images.githubusercontent.com/115066431/235937271-fb0dbe0b-1a47-4097-85d3-5c667f56b623.png)


---ผลการทดลอง `double`

![image](https://user-images.githubusercontent.com/115066431/235937618-9c47c1f1-6483-406b-8cad-b7adbac81bcc.png)

 
---ผลการทดลอง `decimal`
 
 ![image](https://user-images.githubusercontent.com/115066431/235937754-eb1fd9ad-39ac-4da2-af58-3b47f3375d22.png)

---ผลการทดลอง `long`

![image](https://user-images.githubusercontent.com/115066431/235937929-e552c593-ee7c-42d7-8a40-de901e088ff8.png)


---ผลการทดลอง `ulong`

![image](https://user-images.githubusercontent.com/115066431/235938139-914771b9-fa17-4065-a86e-6335659e3b34.png)


---ผลการทดลอง `bool`

![image](https://user-images.githubusercontent.com/115066431/235938570-4c8ff8d9-71de-4a89-b941-ae195627a6cb.png)

---ผลการทดลอง `sbyte`

![image](https://user-images.githubusercontent.com/115066431/235938832-6af414d2-df99-418f-a095-5f52b6d7df75.png)

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
44
59
97
5
91
31
59
41
63


## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
