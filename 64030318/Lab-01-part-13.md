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
| `time` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `do` |ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Do` |ใช้ได้ |ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `21November`|ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `ladkrabang`| ใช้ได้|ไม่มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |
| `Student ID`|ใช้ไม่ได้ |มีตัวอักษรที่ละเมิดกฎการตั้งชื่อ |


---ผลการทดลอง
![image](https://user-images.githubusercontent.com/116150760/232765025-f51e5df2-5d4b-4e0d-bff0-35a857475d88.png)


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
![image](https://user-images.githubusercontent.com/116150760/232765945-d209eb14-c322-4c31-ba6c-4247d8d5cd49.png)

---ผลการทดลอง `byte`
![image](https://user-images.githubusercontent.com/116150760/232766129-5a3ea4ee-5ea6-4dfb-9939-106ed87dc7b8.png)

---ผลการทดลอง `short`
 
![image](https://user-images.githubusercontent.com/116150760/232766429-e8ca792c-718a-4116-8abc-1b9d6a0a4d44.png)


---ผลการทดลอง `ushort`

 ![image](https://user-images.githubusercontent.com/116150760/232766627-9ed33652-3c4f-4ae0-bdb7-f21e1b3b0de6.png)

---ผลการทดลอง `uint`
![image](https://user-images.githubusercontent.com/116150760/232767054-8cc58106-cbcc-4729-bcd1-c68460c5a78a.png)

 

---ผลการทดลอง `float`
 ![image](https://user-images.githubusercontent.com/116150760/232767419-dbeafdcc-d874-4a4a-a627-616ce08b4952.png)


---ผลการทดลอง `double`
 ![image](https://user-images.githubusercontent.com/116150760/232767605-c40810e9-b830-4936-9b79-02aea7b91481.png)

---ผลการทดลอง `decimal`
 ![image](https://user-images.githubusercontent.com/116150760/232767803-44596151-c524-40d9-b115-44ece0df805b.png)

---ผลการทดลอง `long`
![image](https://user-images.githubusercontent.com/116150760/232768001-75614084-1cc8-4ac1-a647-2e421047892f.png)


---ผลการทดลอง `ulong`
![image](https://user-images.githubusercontent.com/116150760/232768056-a6e366e9-e355-433c-833d-bdcbb11be49e.png)


---ผลการทดลอง `bool`
![image](https://user-images.githubusercontent.com/116150760/232768373-c5b8a217-66b4-486c-a70c-1c3b61123a67.png)

---ผลการทดลอง `sbyte`
![image](https://user-images.githubusercontent.com/116150760/232768659-95aca477-2f6d-4f53-96b0-60f619e76d84.png)


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
