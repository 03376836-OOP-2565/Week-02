# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` |ไม่ได้| เป็น keyword ในภาษา C# แทนค่า null ดังนั้นไม่สามารถตั้งชื่อตัวแปรเป็น null ได้|
| `_value` |ใช้ได้ |ไม่มีปัญหาในการตั้งชื่อตามกฎการตั้งชื่อ  |
| `First-name`|ไม่ได้ |ตัวอักษร dash (-) ไม่ได้รับอนุญาตให้ใช้ในการตั้งชื่อตัวแปร  |
| `Hello!` | ไม่ได้ | ตัวอักษรสัญลักษณ์ (!) ไม่ได้รับอนุญาตให้ใช้ในการตั้งชื่อตัวแปร|
| `w*h` |ไม่ได้ |ตัวอักษรสัญลักษณ์ * ไม่ได้รับอนุญาตให้ใช้ในการตั้งชื่อตัวแปร  |
| `time` |ใช้ได้  |ไม่มีปัญหาในการตั้งชื่อตามกฎการตั้งชื่อ  |
| `do` | ไม่ได้ |เป็น keyword ในภาษา C# แทนคำสั่งวนลูป do-while ดังนั้นไม่สามารถตั้งชื่อตัวแปรเป็น do ได้  |
| `Do` |ใช้ได้ |ไม่มีปัญหาในการตั้งชื่อตามกฎการตั้งชื่อ  |
| `21November`|ไม่ได้ |ตัวเลขไม่ได้รับอนุญาตให้ใช้ในการตั้งชื่อตัวแปรเป็นตัวอักษรตัวแรก  |
| `ladkrabang`|ใช้ได้ |ไม่มีปัญหาในการตั้งชื่อตามกฎการตั้งชื่อ  |
| `Student ID`|ไม่ได้ |ตัวอักษรสัญลักษณ์ space (ช่องว่าง) ไม่ได้รับอนุญาตให้ใช้ในการตั้งชื่อตัวแปร |


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

![image](https://github.com/Poramat45/Week-02/assets/115066249/63c84f2f-a9c3-450d-adeb-5cdf032b1345)


---ผลการทดลอง `byte`

![image](https://github.com/Poramat45/Week-02/assets/115066249/311e5b03-42a2-4151-902a-0ef79abc21ee)


---ผลการทดลอง `short`
 
 ![image](https://github.com/Poramat45/Week-02/assets/115066249/b4f599f0-76d0-40f7-a25e-d479ad8f4d6a)


---ผลการทดลอง `ushort`

![image](https://github.com/Poramat45/Week-02/assets/115066249/5ff07a82-4333-4646-a43e-611499f8642a)

 

---ผลการทดลอง `uint`

 
 ![image](https://github.com/Poramat45/Week-02/assets/115066249/dce30525-be47-429a-b89c-30e651936ec7)


---ผลการทดลอง `float`
 
 ![image](https://github.com/Poramat45/Week-02/assets/115066249/c2971387-b70d-4f84-a11e-5ab3b6509feb)


---ผลการทดลอง `double`

![image](https://github.com/Poramat45/Week-02/assets/115066249/f75b46a0-4635-4c91-90d6-9169c1564a33)

 
---ผลการทดลอง `decimal`
 
 ![image](https://github.com/Poramat45/Week-02/assets/115066249/65d1f552-1970-4f08-927e-50ea2b5d9947)

 
---ผลการทดลอง `long`

![image](https://github.com/Poramat45/Week-02/assets/115066249/6cc83afb-34c2-443e-b070-395c4eb7e644)


---ผลการทดลอง `ulong`

![image](https://github.com/Poramat45/Week-02/assets/115066249/1dc3766d-64fd-4b1c-bceb-e2f6b343d870)


---ผลการทดลอง `bool`

![image](https://github.com/Poramat45/Week-02/assets/115066249/586c24f3-5b73-4284-ae69-2bbf2f512137)


---ผลการทดลอง `sbyte`

![image](https://github.com/Poramat45/Week-02/assets/115066249/3bce4cb4-8b2b-4500-8a2a-140c9b035eb1)



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

![image](https://github.com/Poramat45/Week-02/assets/115066249/1c787696-943f-481e-b379-6399df4e1d87)


## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
