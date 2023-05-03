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
![image](https://user-images.githubusercontent.com/100436724/235935149-86e25c37-bc5c-4e26-83be-e7c48cad0b98.png)

---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/100436724/235935363-c3d0f25f-ef3b-456a-90e2-1e655dadfac3.png)

---ผลการทดลอง `short`
 ![image](https://user-images.githubusercontent.com/100436724/235935454-e8f77534-641f-4bc0-834e-96a6c0cf96ae.png)


---ผลการทดลอง `ushort`

 ![image](https://user-images.githubusercontent.com/100436724/235935547-0b005ab1-bc42-46e9-809e-6ef6ed110a2d.png)


---ผลการทดลอง `uint`

![image](https://user-images.githubusercontent.com/100436724/235937430-8fe4c0cc-f269-4497-8f9e-57467e0b0b41.png)


---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/100436724/235937590-3d6e5850-4391-4419-bfe5-dbd2c9e75d56.png)


---ผลการทดลอง `double`
![image](https://user-images.githubusercontent.com/100436724/235937733-c237a9b1-8048-4cc5-8722-f420216090aa.png)

 
---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/100436724/235937871-632e7c63-367b-4c29-bbe4-47688af68a7f.png)

---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/100436724/235938399-b573dd7b-afe6-4dc1-bcd5-ce9210c9806b.png)


---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/100436724/235938312-7a7abc91-40c5-485d-a498-0a1bccffa3fc.png)


---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/100436724/235938622-40ede56b-46de-40ab-b0e3-8ac5b20b55fe.png)

---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/100436724/235938769-e34b2b0b-ebf4-4c48-a985-c79b0bc51882.png)


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

![image](https://user-images.githubusercontent.com/100436724/235939282-3c1da57c-00ba-4ee8-baff-ff5162c381d4.png)
![image](https://user-images.githubusercontent.com/100436724/235939363-2c27f8db-8080-4b62-a250-b4df5ff70a20.png)
![image](https://user-images.githubusercontent.com/100436724/235939431-a21ee147-76a4-4212-bc0d-efacf10de76b.png)
![image](https://user-images.githubusercontent.com/100436724/235939468-e38f03e8-6ffb-4cdf-b417-18e7ae902c07.png)
![image](https://user-images.githubusercontent.com/100436724/235939532-60e31593-a9d5-4ff0-80a5-39e1f75a194b.png)
![image](https://user-images.githubusercontent.com/100436724/235939587-f422f72f-2ffe-4bdb-9f0d-7a014a41bb28.png)
![image](https://user-images.githubusercontent.com/100436724/235939619-61dd140b-4408-4d13-aec0-abe0aafdfe10.png)
![image](https://user-images.githubusercontent.com/100436724/235939683-ef42927d-51ba-4c41-a455-8e9522092621.png)
![image](https://user-images.githubusercontent.com/100436724/235939756-a34e9639-9550-421d-ba45-8d0175d57e94.png)
![image](https://user-images.githubusercontent.com/100436724/235939808-e54b9e1a-900f-4fa9-93fa-ff6c893c022e.png)


## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
