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

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/49b21ba5-f5a0-4397-81ea-74ce5b62d473)


```text
Data type : int
Size :4
Minimum Value :-2147483648
Maximum Value :2147483647
```

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/dbab535b-5393-4c18-adf4-eff139b89d08)


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

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/df72aa0f-ff89-4c2d-b570-9b8d277e57b4)

---ผลการทดลอง `byte`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/a3dd5fb3-dd23-47d1-b41e-3e98f89acc95)

---ผลการทดลอง `short`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/61d62ec2-63dd-4a56-9b5f-4c96e1ef945a) 

---ผลการทดลอง `ushort`

 ![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/156b243a-4855-4690-bc77-ec50a742c36a)

---ผลการทดลอง `uint`

 ![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/a00b6d2f-a95a-4445-a20b-c2b8552f1c61)

---ผลการทดลอง `float`

 ![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/478f752c-739d-4700-80c2-7b734b294203)

---ผลการทดลอง `double`

 ![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/db85b31b-2fb0-41b5-8bd2-d09ee5d0f55d)

---ผลการทดลอง `decimal`

 ![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/b7c9c1f5-1ed3-4141-a167-4a4b65073590)

---ผลการทดลอง `long`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/ff29380f-ff57-4503-9a94-8f47d2c39fff)

---ผลการทดลอง `ulong`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/20ee73ea-dc88-4182-affa-ffd28f9bcdd0)

---ผลการทดลอง `bool`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/2bc93e82-1c41-42a5-9f18-e26e0a74abe7)

---ผลการทดลอง `sbyte`

![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/72ba3e8e-9fb8-44d7-ae39-2179fa875a05)


## การใช้งานข้อมูลชนิดต่างๆ

ข้อมูลชนิดตรรกะ The Boolean Type
ข้อมูลชนิดตรรกะ (boolean) มีค่าที่เป็นไปได้เพียง 2 ค่าเท่านั้นคือ true และ false ในภาษา C# จะไม่สามารถกำหนดค่าตัวเลขลงไปในตัวแปร boolean ได้ ส่วนใหญ่ตัวแปร boolean มักใช้เพื่อการตัดสินใจและมีที่มาจากการประเมินค่าสมการต่างๆ ตัวอย่างต่อไปนี้เป็นการใช้ตัวแปร boolean กับการเปรียบเทียบด้วยตัวดำเนินการ “>”
ตัวอย่าง

```csharp
bool a = 4 > 5;
Console.WriteLine("4 > 5 is {0}", a);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/2bb8bf29-52e9-4e20-9c8e-37aa4b5a39f8)

## สนุกกับการสร้างตัวเลขสุ่ม

ในภาษา C# มีวิธีการสร้างตัวเลขสุ่ม (random number) โดยใช้คลาส Random มาสร้างเป็นตัวแปรโดยมีรูปแบบดังนี้

```csharp
Random random = new Random();
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/e606316f-057c-4247-8e98-26a40647f9f4)

เมื่อสร้างแล้ว เราสามารถนำมาหาค่าตัวเลขสุ่มจากตัวแปรดังกล่าว ซึ่งมักจะกำหนดค่าสูงสุดและต่ำสุดในการสุ่มลงไปด้วย ดังนี้

```csharp
int randomNumber = random.Next(0, 100);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/c0dd7998-d74e-473a-ba6f-01dcc383dc4a)

โปรแกรมด้านล่างนี้เป็นตัวอย่างการสุ่มเลข 0 – 100

```csharp
Random random = new Random();
int randomNumber = random.Next(0, 100);
Console.WriteLine(randomNumber);
```
![image](https://github.com/TanapatPluemchai/Week-02/assets/115067806/7b0a44a8-f416-4f5c-84c7-4578f069d788)
 
ให้รัน 10 ครั้งแล้วบันทึกค่าที่ได้จากการรัน

## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
