# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115037574/213251535-5f490cc7-3d1b-4203-9564-d14ac3c71380.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
```
แสดงผล HelloHello
```
### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115037574/213254946-155ea570-4682-43d9-9579-6787ab291249.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
```
แสดงผล Hello คนละบรรทัด
Hello
Hello
```
## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115037574/213255514-e7cdc4aa-2a23-4575-8363-fa7974d5a8f8.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://user-images.githubusercontent.com/115037574/213255903-4f99adb9-713e-41c5-bc41-a8ac4c994e90.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
```
แสดงผล Hello, World! ในบรรทัดเดียวกัน เพราะมีคำสั่ง Console.Write อยู่ก่อนหน้าจึงทำให้คำว่า World! อยู่บรรทัดเดียวกันกับ Hello,
```

❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
```
คำสั่ง Console.Write() เป็นการแสดงผล ให้อยู่ในบรรทัดเดียวกัน
คำสั่ง Console.WriteLine() เป็นการแสดงผล ให้อยู่บรรทัดใหม่ (ขึ้นบรรทัดใหม่)
```

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
