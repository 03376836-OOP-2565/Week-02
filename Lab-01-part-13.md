# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `_value` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `First-name`|ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Hello!` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `w*h` | ใช้ไม่ได้|มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `time` | ใช้ได้| ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ|
| `do` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Do` |	ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ|
| `21November`|ใช้ไม่ได้ | มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ|
| `ladkrabang`| ใช้ได้|ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Student ID`|ใช้ไม่ได้ | มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ|


---ผลการทดลอง
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/595f9e18-5dd5-4d05-aeb2-3404fb76dfc7)


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
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/b3fcf33a-3b87-4ad2-b2a4-6e62e0ddeb4b)


---ผลการทดลอง `byte`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/6495962c-0b76-4a70-8090-95805874f099)

---ผลการทดลอง `short`
 ![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/c4b9abbc-696d-4528-b2ec-0c4acbee6187)


---ผลการทดลอง `ushort`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/dfe2cf31-2238-495b-ab68-6369019aae14)

 

---ผลการทดลอง `uint`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/70e6da64-7311-4545-94b2-c548ba5da1cf)

 

---ผลการทดลอง `float`
 ![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/9480ebe5-97fd-451a-ab2b-9ab2fe2f4bb8)


---ผลการทดลอง `double`
 ![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/904f2f4a-8b44-446f-9db4-e7d8bca7b9a5)

---ผลการทดลอง `decimal`
 ![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/e55c0132-ed97-4f5b-a5ea-27919a44683e)

---ผลการทดลอง `long`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/4cd81839-b440-4530-9d35-68acd3d22b4b)


---ผลการทดลอง `ulong`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/1689c20e-2bf8-4c85-aca5-919a8277ec21)


---ผลการทดลอง `bool`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/a7b20d14-8756-48a0-9ac1-d46c7696e0ef)

---ผลการทดลอง `sbyte`
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/f1234519-db94-470b-aafb-33ffae962d74)


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
