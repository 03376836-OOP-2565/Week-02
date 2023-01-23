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
![image](https://user-images.githubusercontent.com/115037574/213912501-a1946347-d2c9-4ed5-9427-2a37a4e3f3aa.png)
---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/115037574/213912553-98ac95d5-7b9b-4b11-a033-ec0cce69eb75.png)
---ผลการทดลอง `short`
![image](https://user-images.githubusercontent.com/115037574/213912593-15723892-ac19-47cc-96cc-dbf363d8eca8.png)
---ผลการทดลอง `ushort`
![image](https://user-images.githubusercontent.com/115037574/213912623-5962f979-229e-4f16-832e-fbef9d85e88f.png)
---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/115037574/213912737-333ee378-55d6-46b7-b159-2cb58cff4ccc.png)
---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/115037574/213912768-61da2e81-bdc5-45b1-971d-1686831a2cdb.png)
---ผลการทดลอง `double`
 ![image](https://user-images.githubusercontent.com/115037574/213912799-846650b3-1594-43cf-b0e0-6ce06222e5f3.png)
---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/115037574/213912833-6e689926-b546-417d-9e2a-d0ef6b10e1de.png)
---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/115037574/213912882-248f45cb-0caa-4798-88c7-5a7ee2b2c5c6.png)
---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/115037574/213912918-13c563f4-7bca-459f-9dac-76eb910ee295.png)
---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/115037574/213913131-95669f2e-4e8c-43f3-8762-ec0558416f12.png)
---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/115037574/213913164-8c9a5735-3248-4e3a-82b4-f194b8613fd4.png)

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
## 1
![image](https://user-images.githubusercontent.com/115037574/213913211-9819c8ae-3e98-4740-bc5c-1cd4fe81dbbf.png)
## 2
![image](https://user-images.githubusercontent.com/115037574/213913217-44806052-d5d2-423e-88dd-bdc055130d41.png)
## 3
![image](https://user-images.githubusercontent.com/115037574/213913223-fa242655-1fd6-40ee-bd25-f43c023c90be.png)
## 4
![image](https://user-images.githubusercontent.com/115037574/213913230-a16af63d-6ac7-4db3-a5df-b8e2e3964a06.png)
## 5
![image](https://user-images.githubusercontent.com/115037574/213913235-94139178-9914-48a5-b69c-50e52b7396c5.png)
## 6
![image](https://user-images.githubusercontent.com/115037574/213913239-da6fa3ee-ac95-413f-aed9-9b58a12ad816.png)
## 7 
![image](https://user-images.githubusercontent.com/115037574/213913244-1a0d3519-6447-4c73-b572-e4ad4c171ef9.png)
## 8
![image](https://user-images.githubusercontent.com/115037574/213913249-6aaa5ccd-7f8e-46a0-8f5f-714fa0ec7309.png)
## 9
![image](https://user-images.githubusercontent.com/115037574/213913255-f69871b6-b622-4774-90e4-0a33701f90b3.png)
## 10
![image](https://user-images.githubusercontent.com/115037574/213913262-b542f8be-b4a2-4fc2-85a6-ab1041037a74.png)


## [การเขียนโปรแกรมด้วยตัวดำเนินการทางตรรกะ](./Lab-01-part-14.md)
