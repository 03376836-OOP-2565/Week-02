# Lab-01 Part 4 จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()

โดยทั่วไป การพิมพ์ข้อความออกทาง console สามารถพิมพ์ข้อความได้ทั้งแบบตายตัวและเปลี่ยนแปลงได้โดยโปรแกรม หากเราต้องการพิมพ์แบบตายตัวก็อาจใช้คำสั่ง `Console.WriteLine` เขียนเรียงกันไปเรื่อยๆ 

👉 แก้โปรแกรมตามรูปด้านล่างนี้

```csharp
Console.WriteLine("This is text 1.");
Console.WriteLine("This is text 2.");
Console.WriteLine("This is text 3.");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115067806/221782728-201c4e3a-1727-4c76-ba1d-d980b13e2b64.png)


ถ้าหากต้องการให้แก้ไขค่าตัวแปรที่จะแสดงออกทาง console เราก็อาจจะใช้ป้ายกำกับสำหรับรับค่าออกไปแสดงที่ output เรียกว่า place holder

การนับลำดับ place holder จะเริ่มจากตัวแรกที่มีค่าเป็น 0

👉 แก้โปรแกรมตามรูปด้านล่างนี้

```csharp
Console.WriteLine(" {0} and {1}", 3, 6);
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115067806/221783264-45d0e6e3-92a7-4fc7-ba51-2d003517bc00.png)


❔ ถ้ามีการใช้ตัวเลขใน { } ที่กระโดด เช่น {0} {2} {3} จะใช้งานได้หรือไม่ อย่างไร จงอธิบาย

### สามารถทำได้

👉แก้โปรแกรมตามรูปด้านล่างนี้

```csharp
Console.WriteLine("{1}, {0} and {1}", 3, 6);
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115067806/221784223-873ccc20-7bec-43cf-ab1f-637407fa688e.png)

 
## [5. การกำหนดความกว้างของอาร์กิวเมนต์](./Lab-01-part-5-7.md)
