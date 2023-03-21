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


---ผลการทดลอง<br>
![image](https://user-images.githubusercontent.com/115066298/226599452-e7390211-6b97-43fa-b7b3-9b853acd63f2.png)



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
---ผลการทดลอง `char`<br>
![image](https://user-images.githubusercontent.com/115066298/226599548-6eb2540d-b0d4-4bb0-9a74-e277ca316d51.png)


---ผลการทดลอง `byte`<br>
![image](https://user-images.githubusercontent.com/115066298/226599597-bb9cf65e-2d62-4e52-97af-b3f28f8548ba.png)


---ผลการทดลอง `short`<br>
![image](https://user-images.githubusercontent.com/115066298/226599677-56372329-e1f1-4b7f-aa10-46069d7b25fd.png)

 

---ผลการทดลอง `ushort`<br>
![image](https://user-images.githubusercontent.com/115066298/226599758-55dadc22-54af-455e-b341-5604960afca5.png)


 

---ผลการทดลอง `uint`<br>
![image](https://user-images.githubusercontent.com/115066298/226599817-0cc4e692-92ae-4398-af71-85fcd63d4c61.png)


 

---ผลการทดลอง `float`<br>
![image](https://user-images.githubusercontent.com/115066298/226599868-4b84fe70-54ef-4d5f-a25b-28512a9c3a84.png)

 

---ผลการทดลอง `double`<br>
![image](https://user-images.githubusercontent.com/115066298/226599913-68d20510-fcd4-4bd8-a6ed-5ad1961dc50a.png)

 
---ผลการทดลอง `decimal`<br>
![image](https://user-images.githubusercontent.com/115066298/226599979-10c5c6ba-03cf-47e6-a4e7-42bf7eb7a580.png)

 
---ผลการทดลอง `long`<br>
![image](https://user-images.githubusercontent.com/115066298/226600028-1f4dd37d-9b3d-4947-a1aa-a6a4e42a0a59.png)



---ผลการทดลอง `ulong`<br>
![image](https://user-images.githubusercontent.com/115066298/226600076-34713024-82f2-4323-94b3-422748053dab.png)



---ผลการทดลอง `bool`<br>
![image](https://user-images.githubusercontent.com/115066298/226600131-39a5543f-cf2f-4781-8cf5-673955fb3280.png)


---ผลการทดลอง `sbyte`<br>
![image](https://user-images.githubusercontent.com/115066298/226600188-6c38caf8-3aea-4cd9-9509-fbabd76d20c9.png)



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
