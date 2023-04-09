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
ชื่อตัวแปร ใช้ได้/ไม่ได้ เหตุผล

xxx ใช้ได้ ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ

null ใช้ได้ เป็นคำสงวนในภาษา C# และเป็นตัวแปรสำหรับเก็บค่า null

_value ใช้ได้ ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ แต่อาจเกิดความสับสนได้กับตัวแปรชนิดคลาสที่มี Property ชื่อ _value อยู่แล้ว

First-name ไม่ใช้ได้ มีเครื่องหมายขีดกลางไม่สามารถใช้ในชื่อตัวแปรได้

Hello! ไม่ใช้ได้ มีเครื่องหมาย ! ไม่สามารถใช้ในชื่อตัวแปรได้

w*h ไม่ใช้ได้ มีเครื่องหมาย * ไม่สามารถใช้ในชื่อตัวแปรได้

time ใช้ได้ ไม่มีข้อจำกัดในการตั้งชื่อตัวแปร แต่อาจเกิดความสับสนได้กับคำสงวนในภาษาอื่นๆ

do ไม่ใช้ได้ เป็นคำสงวนในภาษา C# และไม่สามารถใช้ในชื่อตัวแปรได้

Do ใช้ได้ ไม่มีข้อจำกัดในการตั้งชื่อตัวแปร แต่อาจเกิดความสับสนได้กับคำสงวนในภาษาอื่นๆ

21November ใช้ได้ ไม่มีข้อจำกัดในการตั้งชื่อตัวแปร แต่อาจเกิดความสับสนได้กับการตั้งชื่อที่เป็นตัวเลขเป็นอย่างเดียว

ladkrabang ใช้ได

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
![Screenshot 2023-04-09 165539](https://user-images.githubusercontent.com/115066186/230766309-53f9d46b-a56f-4163-8e95-f2e8f259a387.png)

---ผลการทดลอง `byte`
![Screenshot 2023-04-09 165749](https://user-images.githubusercontent.com/115066186/230766557-4184ede1-7a7a-444f-a483-430fb653990b.png)

---ผลการทดลอง `short`
 ![Screenshot 2023-04-09 165817](https://user-images.githubusercontent.com/115066186/230766560-a8f8efea-e260-42ec-881f-ceead7afe388.png)


---ผลการทดลอง `ushort`
![Screenshot 2023-04-09 165837](https://user-images.githubusercontent.com/115066186/230766563-f7428141-032d-4bd9-abae-6f16f0d67ff7.png)

 

---ผลการทดลอง `uint`

 ![Screenshot 2023-04-09 165911](https://user-images.githubusercontent.com/115066186/230766566-5286ade3-15b8-4e5c-8b43-4c3944b041e4.png)


---ผลการทดลอง `float`
 ![Screenshot 2023-04-09 165931](https://user-images.githubusercontent.com/115066186/230766573-939f044f-c0a3-4e12-a3bf-42bba80ee066.png)


---ผลการทดลอง `double`
 ![Screenshot 2023-04-09 170009](https://user-images.githubusercontent.com/115066186/230766576-3b5b4b74-9fe5-43d2-9678-883c0c596e21.png)

---ผลการทดลอง `decimal`
 ![Screenshot 2023-04-09 170031](https://user-images.githubusercontent.com/115066186/230766578-be6c6763-044e-4b07-bebd-9585a6948c05.png)

---ผลการทดลอง `long`
![Screenshot 2023-04-09 170051](https://user-images.githubusercontent.com/115066186/230766579-4cff377a-828b-4396-b721-52f208ec5ea2.png)


---ผลการทดลอง `ulong`
![Screenshot 2023-04-09 170105](https://user-images.githubusercontent.com/115066186/230766581-cd35b45c-5f62-412b-a4f4-d9f9340361d4.png)


---ผลการทดลอง `bool`
![Screenshot 2023-04-09 170156](https://user-images.githubusercontent.com/115066186/230766586-539195b2-4762-4895-9d52-24c6a0cd043b.png)

---ผลการทดลอง `sbyte`
![Screenshot 2023-04-09 170214](https://user-images.githubusercontent.com/115066186/230766588-3adbc5a5-e8e9-4eb9-b436-840f04ef9da9.png)


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
![Screenshot 2023-04-09 164846](https://user-images.githubusercontent.com/115066186/230766235-f3afe233-bad1-4056-8ff1-3b3afd0a709e.png)
![Screenshot 2023-04-09 164851](https://user-images.githubusercontent.com/115066186/230766237-5f5234d9-c115-4acc-a426-ca58f99a75e3.png)
![Screenshot 2023-04-09 164855](https://user-images.githubusercontent.com/115066186/230766238-a5ce8ba0-a872-4dbc-928d-e9789b56795e.png)
![Screenshot 2023-04-09 164900](https://user-images.githubusercontent.com/115066186/230766239-8e1a1efa-d007-4a0b-8950-e69c6ad4c4cd.png)
![Screenshot 2023-04-09 164903](https://user-images.githubusercontent.com/115066186/230766240-44837a43-2ae0-474a-976b-5868977f77a9.png)
![Screenshot 2023-04-09 164908](https://user-images.githubusercontent.com/115066186/230766241-1f630782-c3e7-4afb-9e3d-f0aa6b6978bd.png)
![Screenshot 2023-04-09 164817](https://user-images.githubusercontent.com/115066186/230766243-10c8c16a-4844-4fa6-a07e-2d3695b66acf.png)
![Screenshot 2023-04-09 164826](https://user-images.githubusercontent.com/115066186/230766246-05a15e5d-e603-43bc-90a4-549982b529f6.png)
![Screenshot 2023-04-09 164831](https://user-images.githubusercontent.com/115066186/230766248-d47915cd-0c78-40e7-964a-6c5c30c49963.png)
![Screenshot 2023-04-09 164841](https://user-images.githubusercontent.com/115066186/230766249-153a9a09-abd6-412a-8daa-2a9a2ae352a5.png)

## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
