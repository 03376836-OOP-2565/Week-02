# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
![1](https://user-images.githubusercontent.com/115066186/230763537-f8a6dee5-2d4b-4ee2-9e68-35b6559fa4cd.png)
เป็นไปตามที่คาดการณ์ไว้ โดนที่การแสดงผลจะยังอยู่ติดกัน
### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
![2](https://user-images.githubusercontent.com/115066186/230763566-b4e9aa58-2c1b-49c3-aa76-0a930fdf503e.png)
ไม่คิดว่าการใช้ Environmentline จะทำให้เว้นบรรทัดได้

## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![Screenshot 2023-04-09 155520](https://user-images.githubusercontent.com/115066186/230763693-84cb4087-e562-4078-b2f8-1e6e54d3d893.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![Screenshot 2023-04-09 155547](https://user-images.githubusercontent.com/115066186/230763700-d1c37a90-c305-4105-bfe4-602b48ea4351.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
เป็นไปตามที่คิด ว่าจะแสดงผลทั้งคู่อย่างต่อเนื่องกัน
❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
Console.Write() และ Console.WriteLine() เป็นฟังก์ชั่นสองฟังก์ชั่นหนึ่งที่ใช้ในการแสดงผลข้อความลงบนหน้าจอคอมพิวเตอร์ในภาษา C# โดยมีความแตกต่างดังนี้

Console.Write() จะแสดงผลข้อความบนหน้าจอโดยไม่ขึ้นบรรทัดใหม่หลังจากแสดงผล เมื่อพิมพ์ Console.Write("Hello") กับ Console.Write("World!") ต่อเนื่องกัน ผลที่ได้จะเป็น "HelloWorld!" โดยไม่มีการขึ้นบรรทัดใหม่ระหว่างคำว่า Hello กับ World!

Console.WriteLine() จะแสดงผลข้อความบนหน้าจอและขึ้นบรรทัดใหม่หลังจากแสดงผลเสร็จสิ้น ถ้าพิมพ์ Console.WriteLine("Hello") กับ Console.WriteLine("World!") ต่อเนื่องกัน ผลที่ได้จะเป็น

Hello
World!

โดยจะมีการขึ้นบรรทัดใหม่ระหว่างคำว่า Hello กับ World! นั่นหมายความว่าเมื่อใช้ Console.WriteLine() จะสามารถแสดงผลข้อความในแต่ละบรรทัดได้แยกกันชัดเจนขึ้นมากกว่า Console.Write()

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
