# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล

![](./Images/Lab-01-Pic-01.png)

จากรูป โปรแกรมสามารถรันได้ เหก่ดวสฟกหา่เวกฟเาส

![image](https://user-images.githubusercontent.com/115067806/221779591-c4f5a16d-9fc9-4d71-8f29-e039ac89d43c.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
### เป็นไปตามตัวอย่างที่แสดง

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล

![](./Images/Lab-01-Pic-02.png)


![image](https://user-images.githubusercontent.com/115067806/221780605-762606c7-2640-46ff-a45e-a9bcd892979f.png)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
### เป็นไปตามตัวอย่างที่แสดง


## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

![image](https://user-images.githubusercontent.com/115067806/221781454-d3b36d34-df44-4d18-b1ac-6a5c0eba6292.png)


➢ รันโปรแกรมและบันทึกผล

![](./Images/Lab-01-Pic-03.png)

![image](https://user-images.githubusercontent.com/115067806/221781756-abf1c82b-7213-46df-8b92-df5efb21d168.png)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล

❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
### ผลเป็นที่ได้ตามตัวอย่าง


❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
### มีการเพิ่มข้อความเข้ามา


## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
