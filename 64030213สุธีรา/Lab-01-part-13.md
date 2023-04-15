# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `_value` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `First-name`|ใช้ไม่ได้	 |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Hello!` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `w*h` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `time` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `do` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Do` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `21November`|ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `ladkrabang`|ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ|
| `Student ID`|ใช้ไม่ได้	 |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |


---ผลการทดลอง
![image](https://user-images.githubusercontent.com/115066359/232084851-73a7d44e-b127-439c-9f81-cbc6770cb984.png)


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
![image](https://user-images.githubusercontent.com/115066359/232091905-4570eca8-43e3-428c-a222-74e25243e969.png)


---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/115066359/232092325-00bd041c-3de8-4ca6-9990-215644277c13.png)


---ผลการทดลอง `short`
![image](https://user-images.githubusercontent.com/115066359/232092487-2f3bec0d-cc66-48bc-b533-f3a6807bcfb5.png)

 

---ผลการทดลอง `ushort`
![image](https://user-images.githubusercontent.com/115066359/232095050-e9fafcde-e3a6-40a0-b50c-b61b4677af17.png)

 

---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/115066359/232095631-23eab9a7-b691-4b8f-9bec-738090673679.png)

 

---ผลการทดลอง `float`
![image](https://user-images.githubusercontent.com/115066359/232095875-63b175b7-9c66-456b-8d02-87a23ad60b50.png)

 

---ผลการทดลอง `double`
![image](https://user-images.githubusercontent.com/115066359/232095977-2cfe796f-14eb-4281-86f0-e1c7b5cef7f6.png)

 
---ผลการทดลอง `decimal`
![image](https://user-images.githubusercontent.com/115066359/232096089-39ab54f2-b3c3-42ab-a97b-e16bbab04f6a.png)


 
---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/115066359/232096193-ed8fc5b4-f654-4958-9aa1-c5a598c8445e.png)



---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/115066359/232096268-c5151688-758c-457e-8375-8b7264bdfcd9.png)



---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/115066359/232096545-e1a11e77-2845-489d-a041-b1866c60dac7.png)



---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/115066359/232096721-4dd7fb93-b4e8-4b48-9bd2-f9fd778654ca.png)




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
