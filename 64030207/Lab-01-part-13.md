# Lab-01 การตั้งชื่อตัวแปรและชนิดข้อมูลในภาษา C\#


 ให้นักศึกษาพิจารณาชื่อตัวแปรตามตารางต่อไปนี้ ว่าสามารถใช้ได้หรือไม่ พร้อมบอกเหตุผล

| ชื่อตัวแปร | ใช้ได้/ไม่ได้ | เหตุผล|
|--|--|--|
| `xxx`     | ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `null` | ไม่ได้ | เป็นตัวที่เช็ดว่าเป็นตัวแปรหรือ textbox ว่าเป็นค่าว่างหรือไม่ |
| `_value` | ใช้ได้ |ตัว _ ไม่ได้เป็นตัวดำเนินการ |
| `First-name`| ไม่ได้ | - เป็นตัวดำเนินการ |
| `Hello!` | ไม่ได้ | ! เป็นตัวดำเนินการ |
| `w*h` | ไม่ได้ | * เป็นตัวดำเนินการ |
| `time` | ใช้ได้ | ไม่มีอักษรที่ละเมิดกฏการตั้งชื่อ |
| `do` | ไม่ได้ | เป็นตัวคำสั่ง |
| `Do` | ใช้ได้ | ไม่เป็นตัวคำสั่ง |
| `21November`| ไม่ได้ | ไม่สามารถใช้เลขเป็นตัวแปรได้ |
| `ladkrabang`| ใช้ได้ | ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Student ID`| ไม่ได้ | ไม่สามารถเว้นวรรคได้ |


---ผลการทดลอง
ควรตั้งชื่อให้ง่ายและสอดคล้องกับโปรแกรมที่เราทำ ไม่ควรใช้อักษรทางคณิต ไม่สามารถเว้นวรรคและไม่สามารถนำคำสั่งมาเป็นตัวแปรได้

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

![ภาพ](https://user-images.githubusercontent.com/115066278/217517762-daee85b1-a89b-42df-91fc-15d11bc03402.png)

---ผลการทดลอง `byte`

![ภาพ](https://user-images.githubusercontent.com/115066278/217517883-c79d986a-a9c3-4dd3-b007-276f826e5f59.png)

---ผลการทดลอง `short`

 ![ภาพ](https://user-images.githubusercontent.com/115066278/217517960-95019670-30f6-4155-9fcd-898d505b2dc2.png)

---ผลการทดลอง `ushort`

 ![ภาพ](https://user-images.githubusercontent.com/115066278/217518059-5a9b3e83-576a-443f-9f71-e24a5094b414.png)

---ผลการทดลอง `uint`

 ![ภาพ](https://user-images.githubusercontent.com/115066278/217518253-eb8e0bd0-5abd-4699-b15b-0da426c3845b.png)

---ผลการทดลอง `float`
 
![ภาพ](https://user-images.githubusercontent.com/115066278/217518429-0a663fb7-0f14-4c75-a611-0d1662a224eb.png)

---ผลการทดลอง `double`

 ![ภาพ](https://user-images.githubusercontent.com/115066278/217518540-7753c96b-2596-4737-9436-9ea4b272d47a.png)

---ผลการทดลอง `decimal`

 ![ภาพ](https://user-images.githubusercontent.com/115066278/217518617-a2a5d0ac-d4fc-4282-afe3-6678fdf0eeb3.png)

---ผลการทดลอง `long`

![ภาพ](https://user-images.githubusercontent.com/115066278/217518696-9f47a63e-1c19-4220-ab9f-4271347d945f.png)

---ผลการทดลอง `ulong`

![ภาพ](https://user-images.githubusercontent.com/115066278/217518736-cabf0e8b-fbfa-424c-9e98-087345a51126.png)

---ผลการทดลอง `bool`

![ภาพ](https://user-images.githubusercontent.com/115066278/217518907-8b8a308d-e5c7-46c7-9463-1cebcab955c0.png)

---ผลการทดลอง `sbyte`

![ภาพ](https://user-images.githubusercontent.com/115066278/217518997-97929c98-3f28-49a3-9f5d-91795f8068fd.png)


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

![ภาพ](https://user-images.githubusercontent.com/115066278/217519061-2a9b812b-ebf7-47cd-b069-808d51571031.png)


## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
