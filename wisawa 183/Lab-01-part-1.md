# Lab-01 Basic CSharp Language

## การใช้งานภาษา C# ขั้นพื้นฐาน

## วัตถุประสงค์  

1. เพื่อให้นักศึกษาบอกชื่อ method ที่ใช้ในการแสดงผลบน Text Mode ขั้นพื้นฐานในภาษา C# ได้
2. เพื่อให้นักศึกษาสามารถใช้คำสั่งแสดงผลทางหน้าจอ เบื้องต้นได้

## 1. ตรวจสอบก่อนการทดลอง

- ติดตั้งโปรแกรม visual studio รุ่นล่าสุด ที่รองรับการพัฒนาด้วยภาษา C#
- มี account github เป็นของตนเองและสามารถใช้งานได้ตามปกติ
- สามารถใช้งาน git บน visual studio ได้

### คำสั่ง

* ในการทดลองหรือเขียนโปรแกรมในแต่ละข้อ ให้ทำการ commit ลงใน repository ทุกครั้ง
* ในการทดลองแต่ละหัวข้อ ให้แยก branch ทุกครั้ง เช่น หัวข้อที่ 1 ใช้ชื่อ branch W02P01

#### สัญลักษณ์ที่ใช้หน้าบรรทัดที่สำคัญ  

|สัญลักษณ์| ความหมาย|
|---|---|
|👉 | คำสั่งให้ปฏิบัติ |  
|➢ |การรันโปรแกรมและบันทึกผล  
|❔ |คำถาม ให้ตอบลงในไฟล์ md นี้และล้อมรอบคำตอบด้วยเครื่องหมาย back tick (\') |  
|👷 |การเขียนโปรแกรมด้วยตนเอง |  

## ทบทวนการใช้งานคำสั่งพื้นฐาน Console.Write() และ Console.WriteLine()

## 2. เริ่มต้นพัฒนาโปรแกรม Console ด้วย .NET 6 

### 2.1 เปิด visual studio

![](./Pictures/Pic-01-get-started.png)

1 เลือก Create a new project
### 2.2  หน้าต่าง Create a new project

![](./Pictures/Pic-02-Create-a-new-project.png)

1. เลือก C#
2. เลือก Windows
3. เลือก Console
4. คลิก Next

### 2.3  หน้าต่าง Config your new project

![](./Pictures/Pic-03-Configure-your-new-project.png)

1. กำหนดชื่อ project
2. เลือกตำแหน่งที่ตั้ง
3. กำหนดชื่อ solution name (โดยปกติใช้ชื่อเดียวกับ project name ยกเว้นมีหลาย project  ใน solution)
4. คลิก Next


### 2.4  หน้าต่าง Additional information

![](./Pictures/Pic-04-Additional-information.png)

1. เลือก .NET 6.0 (Long-term support)
2. ไม่ต้องทำเครื่องหมาย [x] หน้าข้อความ Do not use top-level statements
3. คลิก Next

### 2.5  หน้าต่างของโปรแกรม Visual studio

![](./Pictures/Pic-05-Project-windows.png)

1. หน้าต่าง Solution Explorer 
2. ส่วนของโปรแกรมที่ visual studio สร้างมาให้
3. คลิกปุ่ม start debug

### 2.5  หน้าต่างผลลัพธ์ของโปรแกรม

![](./Pictures/Pic-06-Output-windows.png)

1. ข้อความ `"Hello, World!"` ตามพารามิเตอร์ของคำสั่ง `Console.Writeline` 
2. ข้อความบอกว่าถ้าต้องการปิดหน้าต่าง output และกลับไปที่ Visual Studio ให้กดปุ่มใด ๆ บนแป้นพิมพ์หนึ่งครั้ง


## [Part 2 คำสั่ง Console.Write()](./Lab-01-part-2-3.md)
