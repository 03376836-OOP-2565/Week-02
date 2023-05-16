# Lab-01 Part 2~3 คำสั่ง Console.Write() และ Console.WriteLine()

## 2. การใช้เมดธอด Console.Write()

### 2.1 การใช้เมดธอด Console.Write()
👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello");
Console.Write("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/Poramat45/Week-02/assets/115066249/a3aa7459-c237-43c5-ac21-e7cd86de77b3)



❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

	ไม่เหมือนกับที่คิดไว้ เพราะที่คิดไว้คือ เมื่อรันโปรแกรมแล้วจะแสดงข้อความเป็น 2 บรรทัดเรียงลงมา 



### 2.2 การใช้เมดธอด Console.Write() ร่วมกับ  `Environment.NewLine`

`Environment.NewLine` เป็นค่าคงที่ที่ถูกนิยามในภาษา C# เพื่อใช้สำหรับการส่งอักขระขึ้นบรรทัดใหม่ไปยัง console

👉 แก้ไขโปรแกรม ให้เป็นดังด้านล่างนี้

```csharp
Console.Write("Hello" + Environment.NewLine);
Console.Write("Hello" + Environment.NewLine);
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/Poramat45/Week-02/assets/115066249/20585f88-1c14-4d9e-98c7-17079583e047)



❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย


	เป็นเหมือนที่คิดไว้ เพราะได้อ่านคำชี้แจงโค้ดก่อนรันโปรแกรมแล้ว 



## 3. เมดธอด Console.WriteLine()

`Console.WriteLine()` เป็นคำสั่งที่เทียบเท่ากับการใช้  `Console.Write` ร่วมกับ  `Environment.NewLine` ทำให้ประหยัดเวลาในการเขียนโปรแกรม
👉 แก้โปรแกรมในเมดธอด Main() ให้เป็นดังต่อไปนี้

```csharp
Console.WriteLine("Hello");
```

➢ รันโปรแกรมและบันทึกผล
![image](https://github.com/Poramat45/Week-02/assets/115066249/774b4f9f-7a00-4933-a363-c9a8c047e24d)

เมื่อรันโปรแกรมแล้วจะได้ผลเหมือนกับ เมธอด Console.Write()

👉 แก้ไขโปรแกรม ให้เป็นดังรูปด้านล่างนี้

```csharp
Console.Write("Hello, ");
Console.WriteLine("World!");
```

➢ รันโปรแกรมและบันทึกผล

![image](https://github.com/Poramat45/Week-02/assets/115066249/01ec3068-3bc3-491e-9852-a09b8aaa83b3)


❔ ผลที่ได้จากการทดลอง เป็นอย่างที่นักศึกษาคิดหรือไม่ อย่างไร จงอธิบาย

ไม่เหมือนที่คิดไว้ เพราะเมื่อรันโปรแกรมแล้ว มีการเว้นช่องของคำ

❔ จงอธิบายความแตกต่างระหว่างคำสั่ง Console.Write() และ Console.WriteLine()

ทั้งสองคำสั่งนี้มีความเหมือนกัน ตรงที่จะทำการแสดงคำที่พิมพ์ใน()

## [4. จำนวนของอาร์กิวเมนต์ในคำสั่ง Console.WriteLine()](./Lab-01-part-4.md)
