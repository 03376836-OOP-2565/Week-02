# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล

![1](https://user-images.githubusercontent.com/115066431/235912204-a6f57c1b-af49-4970-afdd-d07f142e9f54.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### `` เป็นอย่างที่คิดโปรแกรมจะแสดงผล HelloHello ``

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115066431/235917040-7717dc29-1d44-4601-b1c6-38875b1c1686.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### `` เป็นอย่างที่คิด โปรแกรมจะแสดง Hello ในบรรทัดใหม่ ``

## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115066431/235917816-d3425af3-2fdc-44d4-9556-e10a8eb4006d.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/115066431/235917931-d1e3cb21-c051-4e1c-b383-137e7a5c44ab.png)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
### `` เป็นอย่างที่คิดโปรแกรมจะแสดง Hello, World! ``


❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
### ``  Console.Write ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอ Console.WriteLine ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอแบบขึ้นบรรทัดใหม่ ``

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
