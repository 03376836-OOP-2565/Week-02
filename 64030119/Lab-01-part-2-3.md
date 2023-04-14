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
![image](https://user-images.githubusercontent.com/115066285/232001832-67a14894-c119-436e-980a-03b444b4d4bb.png)

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
![image](https://user-images.githubusercontent.com/115066285/232002702-cde67ba2-26ec-44bf-bf1e-1f8353fd9a59.png)


## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้
![image](https://user-images.githubusercontent.com/115066285/232002970-7f19b8b4-7d08-4cd0-8f1b-464ba968a7e0.png)

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
![image](https://user-images.githubusercontent.com/115066285/232003206-3d8595cd-3d0b-4313-8c48-ebd932a32545.png)


❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
ความแตกต่างระหว่าง Console.Write() และ Console.WriteLine() คือ Console.Write() จะไม่ขึ้นบรรทัดใหม่หลังจากแสดงผล ในขณะที่ Console.WriteLine() จะขึ้นบรรทัดใหม่หลังจากแสดงผลเสร็จ ทำให้ข้อความหรือข้อมูลถัดไปที่แสดงผลจะอยู่บรรทัดใหม่

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
