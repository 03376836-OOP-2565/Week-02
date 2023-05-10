# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/cd3e33ba-91a5-4d1f-a9a7-f2c0f1d2bbea)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
คิดไว้ เพราะ การใส่คำสั่งนี้เป็นการเเสดงคำว่า HelloHello
### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/5ccf86e9-fb79-435b-9776-f4f899be548b)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
เป็นไปอย่างที่คิด เป็นการเเสดงเว้นบรรทัด

## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/d11d84b2-2949-4ce5-bea7-4ac0d82bcc66)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/CHAIYAPRUK/OOP2565-Week-02/assets/115066395/07d2eb69-a2b1-4d1e-aa4f-ac3210dbc116)

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
เป็นไปอย่างที่คิดเพราะ เป็นการเติมคำ
❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
Console.Write() จะแสดงผลข้อความแบบไม่ขึ้นบรรทัดใหม่ (ไม่มีการขึ้นบรรทัดใหม่หลังจากแสดงผล) ในขณะที่ Console.WriteLine() จะแสดงผลข้อความแบบขึ้นบรรทัดใหม่ (มีการขึ้นบรรทัดใหม่หลังจากแสดงผล)

การใช้งาน Console.Write() จะต้องระบุข้อความที่ต้องการแสดงผลตามหลังคำสั่ง ในขณะที่ Console.WriteLine() จะรับข้อความที่ต้องการแสดงผลเป็นอาร์กิวเมนต์และสามารถส่งพารามิเตอร์ได้หลายตัว


## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
