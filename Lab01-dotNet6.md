 # LAB-01 C# Console program


การเขียนโปรแกรมด้วยภาษา C# ใน .NET 6 จะมีสิ่งที่เปลี่ยนแปลงไปจาก .NET รุ่นก่อนหน้า นั่นคือมีการใช้ project template ตัวใหม่ในขณะที่สร้าง project
โดยรูปแบบเริ่มต้นนั้น  visual studio จะสร้าง code ดังนี้ให้ในไฟล์ Program.cs ของเรา

``` C#
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

ผลที่ได้จาการรันโปรแกรมจะยังคงเหมือนกับการใช้ code ต่อไปนี้ใน .NET 5 หรือรุ่นก่อน ๆ  

``` C#
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

โปรแกรมทั้งสองแบบข้างบน สามารถใช้ได้บน C# รุ่น 10.0 ขึ้นไป ดังนั้นเพื่อความกระชับในการเขียนโปรแกรม
เราก็อาจจะเลือกใช้  project template ตัวใหม่นี้ได้ เนื่องจาก compiler ของภาษา C# รุ่นใหม่ ๆ จะรองรับอยู่แล้ว


โดยสรุป ในการพัฒนาโปรแกรม เรามีสองตัวเลือกในการทำงานกับ .NET 6 ขึ้นไป นั่นคือ 

- ใช้รูปแบบโปรแกรมแบบใหม่ โดยเพิ่มคำสั่งระดับบนสุดใหม่เมื่อคุณเพิ่มคุณสมบัติ
- แปลงโปรแกรมแบบเป็นสไตล์เก่า โดยการเพิ่มคลาสเมธอด Main

สำหรับผู้ที่ต้องการเทมเพลตเดิม สามารถกำหนดได้จากการติ๊กตัวเลือก  

 