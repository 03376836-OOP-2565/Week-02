# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/116150760/232722512-ec3f2144-5a5f-436b-9bb5-bf74ac0b1aa0.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/116150760/232722826-849279af-6433-4f44-99a7-802071678f46.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย


## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/116150760/232723013-523447cf-00f2-4e6e-a4da-c030710e57be.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/116150760/232723126-edad1ba5-d043-41bd-accb-da6d5e17c909.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย


❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
Console.Write() - คำสั่งนี้จะแสดงผลข้อความหรือข้อมูลบนหน้าจอหรือคอนโซล โดยไม่ขึ้นบรรทัดใหม่ (new line) หลังจากที่แสดงผลเสร็จ และไม่ต้องการตัวบันทัดใหม่ต่อท้าย

Console.WriteLine() - คำสั่งนี้จะแสดงผลข้อความหรือข้อมูลบนหน้าจอหรือคอนโซล และจะขึ้นบรรทัดใหม่ (new line) หลังจากที่แสดงผลเสร็จ

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
