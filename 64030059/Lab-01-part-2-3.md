# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/100436724/235917140-ae27366f-a70a-4808-82c7-2a0d2fdf92fe.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### ``เป็นอย่างที่คิดเพราะเคยศึกษามาก่อน``

➢ 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/100436724/235917961-2e7fcec1-e67e-47ac-86b4-e70b5718c90e.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

###  `` ไม่เป็นอย่างที่คิดเพราะว่าจะมีการบวกติดกัน ``

## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล

  ![image](https://user-images.githubusercontent.com/100436724/235921511-8df51117-bc1e-488c-b4cd-2403a9e57571.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้


```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://user-images.githubusercontent.com/100436724/235921744-b72cf2fd-fd64-4941-a406-82922036c11e.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

### `` ไม่เป็นอย่างที่คิดเพราะคิดว่าน่าจะต้องติดกัน ``

❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()

### ``  Console.Write แสดงผลแบบไม่ขึ้นบรรทัดใหม่แต่Console.WriteLine จะขึ้นบรรทัดใหม่ ``

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
