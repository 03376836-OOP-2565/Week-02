# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![334088816_939384187231678_6735322205609767475_n](https://user-images.githubusercontent.com/116150897/221583652-a392275a-cbfc-4d55-843a-706174b76eea.jpg)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
2.1 การใช้เมดธอด Console.Write()แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้
Console.Write("Hello");
Console.Write("Hello");

### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![329727053_5668113286634005_789125099393117015_n](https://user-images.githubusercontent.com/116150897/221584220-0542221b-aacb-4089-9d29-20ca57d26f3b.jpg)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
ข้อความที่เขียนไป เป็นรูปแบบบรรทัดใหม่ คำสั่งEnvironment.NewLine เป็ฯคำสั่งที่ใช้เริ่มบรรทัดใหม่เมื่อเขียนต่อท้ายคำที่เรากำหนด

## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![334029919_736861394659339_1367443210083511794_n](https://user-images.githubusercontent.com/116150897/221584516-b7591fd9-560b-4198-aea7-724ed49f7ab3.jpg)


👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล
![333979228_605282011495039_1277785824701990005_n](https://user-images.githubusercontent.com/116150897/221584774-56541ade-59a3-4d5c-b122-84dd9805a709.jpg)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย
3. เมดธอด Console.WriteLine()แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้
Console.WriteLine("Hello");
เป็นคำสั่งที่ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอแบบขึ้นบรรทัดใหม่

❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()
แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้
Console.Write("Hello, ");
Console.WriteLine("World!");
คำสั่ง Console.Write จะออกมาให้รู้แบบข้อความและเว้นช่องไฟ ตามข้อความที่เขียน
คำสั่ง Console.WriteLine เป็นคำสั่งที่ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอแบบขึ้นบรรทัดใหม่ Console.Write ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอ
Console.WriteLine ใช้สำหรับการแสดงผลข้อมูลออกสู่หน้าจอแบบขึ้นบรรทัดใหม่


## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
