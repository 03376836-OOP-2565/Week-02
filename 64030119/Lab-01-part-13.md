# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` | ไม่ได้ | null เป็นการเช็คว่าตัวแปรหรือ textbox เป็นค่าว่างหรือไม่ |
| `_value` | ใช้ได้ | _ ไม่ได้เป็นตัวดำเนินการ |
| `First-name`| ไม่ได้ | - เป็นตัวดำเนินการ |
| `Hello!` | ไม่ได้ | ! เป็นตัวดำเนินการ |
| `w*h` | ไม่ได้ | * เป็นตัวดำเนินการ |
| `time` | ใช้ได้ | ไม่มีอักษรละเมิดกฎการตั้งชื่อ |
| `do` | ไม่ได้ | do เป็นคำสั่ง |
| `Do` | ใช้ได้ | Do ไม่เป็นคำสั่ง |
| `21November`| ไม่ได้ | ไม่สามารถใช้เลขเป็นชื่อตัวแปรได้ |
| `ladkrabang`| ใช้ได้ | ไม่มีอักษรละเมิดกฎการตั้งชื่อ |
| `Student ID`| ไม่ได้ | ไม่สามารถเว้นวรรคชื่อตัวแปรได้ |


---ผลการทดลอง
= ชื่อตัวแปรควรตั้งให้จำง่าย มีความหมายไม่สามารถใช้เครื่องหมายดำเนินการทางคณิตศาสตร์เป็นชื่อตัวแปรได้ ไม่สามารถเว้นวรรคชื่อตัวแปรได้ ไม่สามารถใช้คำที่เป็นคำสั่งมาเป็นชื่อตัวแปรได้

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
![image](https://user-images.githubusercontent.com/115066285/232063372-9e674821-2a55-45b4-97a9-34872101abb9.png)

---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/115066285/232063795-7cfd5289-6ae9-4610-b676-a29bc196b975.png)

---ผลการทดลอง `short`
![image](https://user-images.githubusercontent.com/115066285/232077402-1cc5dd97-5014-471d-8492-64e360f67ad8.png)
 

---ผลการทดลอง `ushort`
![image](https://user-images.githubusercontent.com/115066285/232079628-03a7fcf2-4627-456f-9d5c-87d9a3a6db9a.png)

 

---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/115066285/232080414-fc7b8be1-d968-4bcf-b1a2-dc7733d6538a.png)

 

---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/115066285/232080817-487dcbb3-b502-4da2-b22f-cc467447754a.png)


---ผลการทดลอง `double`
 ![image](https://user-images.githubusercontent.com/115066285/232083117-b3c85b1f-03c5-4fb9-91d7-6504a68e1706.png)

---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/115066285/232084225-cec3fabf-d337-4b13-9171-9b9c03ef2f21.png)

---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/115066285/232084400-633a48d0-e379-457c-ace8-ba08d95c28ba.png)


---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/115066285/232084593-e7afdf8a-4d53-4a48-a708-78e46b4f83bd.png)


---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/115066285/232087897-cea10045-78e9-4693-b01f-e92960c03e79.png)

---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/115066285/232088204-10ddae98-17fa-4a98-9d73-386f5715244e.png)


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
![image](https://user-images.githubusercontent.com/115066285/232088907-5b13e4c4-e188-4231-9d8d-fcca301f83f8.png)

## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
