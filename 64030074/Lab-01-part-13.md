# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

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
![image](https://user-images.githubusercontent.com/115066414/235314676-67195be0-0009-48aa-9baa-503834f8ad51.png)

---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/115066414/235314688-0c612a23-32a3-4b5e-b0cc-c30f88356afd.png)

---ผลการทดลอง `short`
 ![image](https://user-images.githubusercontent.com/115066414/235314705-7d236bb7-1a2c-40d4-b332-d778a48351d8.png)

---ผลการทดลอง `ushort`
![image](https://user-images.githubusercontent.com/115066414/235314722-230a3401-e74b-45da-aac3-8e6f01b13737.png)

---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/115066414/235314748-0768c612-e770-464f-a5fb-c108c7476ca4.png)

---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/115066414/235314787-c144cc07-69cc-4bfd-a39d-81a5bf457f2e.png)

---ผลการทดลอง `double`
 ![image](https://user-images.githubusercontent.com/115066414/235314798-04c79bc4-0d44-4cb2-854f-f2f3db3664ff.png)

---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/115066414/235314821-0f8b84ad-9922-4993-a09b-15441a5904d7.png)

---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/115066414/235314842-6ca1587c-769b-444d-ab70-0b07754b451f.png)

---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/115066414/235314880-5371b9ba-bed2-44ca-9a95-560c0e2f6b7e.png)

---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/115066414/235314901-117d8cf5-22a4-4e2f-8646-614322c1e32f.png)

---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/115066414/235314911-70c71e39-0a2b-439d-bafc-10f84987b668.png)


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
