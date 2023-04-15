# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115066359/232000246-a3223244-f46d-42d2-83a0-85ead30c97d8.png)
เป็นแบบที่คิดไว้เพราะเป็นคำสั่ง Console.Write มันก็เลยอยู่ในบรรทัดเดียวกัน


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115066359/232003263-92c4d606-e7b6-46cd-b7f2-54fd36b7640e.png)



❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย


## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115066359/232003543-6a495c5d-f16e-4e50-bd13-c58d8647bb56.png)




👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115066359/232003942-6758e41e-52f4-405e-914e-7e5283c0a701.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย


❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()

Console.Write() - คำสั่งนี้จะแสดงผลข้อความหรือข้อมูลบนหน้าจอหรือคอนโซล โดยไม่ขึ้นบรรทัดใหม่ (new line) หลังจากที่แสดงผลเสร็จ และไม่ต้องการตัวบันทัดใหม่ต่อท้าย

Console.WriteLine() - คำสั่งนี้จะแสดงผลข้อความหรือข้อมูลบนหน้าจอหรือคอนโซล และจะขึ้นบรรทัดใหม่ (new line) หลังจากที่แสดงผลเสร็จ

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
