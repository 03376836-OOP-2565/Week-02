# Lab-01  ชนิดข้อมูลตัวเลขจำนวนเต็ม (Integer Types)

ข้อมูลชนิดตัวเลขจำนวนเต็ม สามารถนำไปใช้งานได้หลากหลาย เช่น การนับหรือแสดงจำนวน การกำหนดลำดับที่ การจัดลำดับ เป็นต้น ค่าที่ใส่ลงในตัวแปร เป็นได้ทั้งค่าบวก ค่าศูนย์ และค่าลบ (มีตัวแปรบางชนิดที่เก็บเฉพาะค่าบวกเพียงอย่างเดียว) การกำหนดค่าใดๆ ให้กับตัวแปร ทำได้โดยการใช้เครื่องหมาย =
การใช้เครื่องหมายคณิตศาสตร์กับตัวแปรจำนวนเต็ม สามารถใช้ได้ทุกเครื่องหมาย ได้แก่ +, -, *, / และ %

## 15. การใช้เครื่องหมายทางคณิตศาสตร์กับตัวแปรชนิดจำนวนเต็ม

👉 ให้เขียนโปรแกรมต่อไปนี้

```csharp
int a, b, c, d, e, f;
a = 1;
b = a + 6;
c = b - 3;
d = c * 2;
e = d / 2;
f = e % 2;
Console.WriteLine("a={0}", a);
Console.WriteLine("b={0}", b);
Console.WriteLine("c={0}", c);
Console.WriteLine("d={0}", d);
Console.WriteLine("e={0}", e);
Console.WriteLine("f={0}", f);
```

➢ รันโปรแกรมและบันทึกผล

![ภาพ](https://user-images.githubusercontent.com/115066278/217520635-868c16df-e63d-442e-b20c-ca677b458cc8.png)


## 16. หาค่าจากสมการทางคณิตศาสตร์

กำหนด ```a = 10, b = 20, x = 5, y = 2``
👉 ให้เขียนโปรแกรมเพื่อหาผลลัพธ์ของสมการต่อไปนี้

1. `a+b`
2. `x-b`
3. `x*b`
4. `y/a`
5. `b%y`
6. `y+10%x`
7. `a/3*5`
8. `9/2*a`
9. `y%8`
10. `100*x+y%2-a`

![ภาพ](https://user-images.githubusercontent.com/115066278/217520667-56df4e2e-9615-46c5-907a-d1cf39d59ddf.png)

## ชนิดข้อมูลเลขทศนิยม (Floating Point and Decimal Types)

ตัวเลขจำนวนทศนิยม มักจะใช้ในการคำนวณทางวิทยาศาสตร์ เนื่องจากค่าในวิทยาศาสตร์ต้องการความละเอียดสูง หรือมีค่าสูงมากกว่าที่เลขจำนวนเต็มจะเก็บได้

### ตัวอย่างการแก้ปัญหาทางวิทยาศาสตร์

ระยะทางจากดาวอาทิตย์ถึงโลกคือ 93,000,000 ไมล์ เรียกว่า 1 A.U. (Astronomical Unit)
ความเร็วในการเดินทางของแสงคือ 186,000 ไมล์ต่อวินาที
ระยะทาง 1 ไมล์ คิดเป็น 1.609344 กิโลเมตร
ให้เขียนโปรแกรมหาระยะทางในการเดินทางของแสง ในหน่วยกิโลเมตรต่อวินาทีและเวลาในการเดินทางของแสงจากดวงอาทิตย์มายังโลก

## 17.  โปรแกรมคำนวณระยะทางและเวลาของแสงจากดวงอาทิตย์ถึงโลก

👉 ให้เขียนโปรแกรมต่อไปนี้

```csharp
const double lightSpeed = 186000d;   // miles per second
Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
const double mileTokm = 1.609344;
Console.WriteLine("Light speed = {0} km Per second", lightSpeed*mileTokm);
const double SunToEarthDistance =  93000000d ;  // miles
Console.WriteLine("SunToEarthDistance = {0} km", SunToEarthDistance * mileTokm);
double SunToEarthTimeOfLight = SunToEarthDistance / lightSpeed;  // miles
Console.WriteLine("SunToEarthTimeOfLight = {0} seconds", SunToEarthTimeOfLight);
Console.WriteLine("SunToEarthTimeOfLight = {0} minutes", SunToEarthTimeOfLight/60d);
```

➢ รันโปรแกรมและบันทึกผล

![ภาพ](https://user-images.githubusercontent.com/115066278/217520727-6d4c6e73-0480-4a76-9d91-7fced9b260f6.png)




👷 คำสั่ง ให้เขียนโปรแกรมคำนวณค่าเพื่อเติมลงในช่องว่างในตาราง
ตารางที่ 1 ระยะทางจากดวงอาทิตย์ถึงดาวเคราะห์ต่างๆ

| ดาวเคราะห์ | ระยะทางจากดวงอาทิตย์ | ระยะทางในหน่วย A.U. | เวลาของแสง (นาที)
|---|---|---|---|
| Mercury | 57,910,000 km | 35,983,606 mile |5.2 minutes |
| Venus | 108,200,000 km | 67,232,363 mile | 9.7 minutes |
| Earth | 149,600,000 km | 92,957,130 mile | 13.4 minutes |
| Mars | 227,940,000 km | 141,635,350 mile | 20.4 minutes |
| Jupiter |  778,330,000 km | 483,631,840 mile | 69.7 minutes |
| Uranus | 2,873,550,000 km | 1,785,541,189 mile | 257.4 minutes |
| Neptune | 4,501,000,000 km | 2,796,791,736 mile | 403.3 minutes |
| Pluto | 5,945,900,000 km | 3,694,610,971 mile |532.7 minutes |



 คลาส Math ในภาษา C# มีคลาสที่เป็นตัวช่วยคำนวณทางคณิตศาสตร์ ที่ช่วยให้เราสามารถคำนวณฟังก์ชันพื้นฐานได้ อย่างรวดเร็ว ไม่ต้องพัฒนาโปรแกรมเพิ่มเติมด้วยเอง นั่นคือคลาส Math ฟังก์ชันทางคณิตศาสตร์ที่ใช้บ่อยๆ สามารถดูรายละเอียดทั้งหมดได้จาก `system.math`

 
## 20.  โปรแกรมพล็อตรูป sine wave บนหน้าจอ

👉 ให้เขียนโปรแกรมต่อไปนี้

```csharp
for (float i = 0; i < Math.PI * 2.0F; i += 0.3F)
{
    Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" + spaces(Math.Sin(i)) + "*", i, Math.Sin(i));
}
string spaces(double val)
{
    string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
    return SpaceString;
}
```

หมายเหตุ ในการเขียนโปรแกรมภาษา C# .NET6.0 ที่ใช้ template แบบใหม่ เราก็ยังคงสามารถสร้าง function ใช้งานได้ตามปกติ (แต่จะไม่ครอบคลุม feature ทั้งหมดใน OOP )

➢ รันโปรแกรมและบันทึกผล

![ภาพ](https://user-images.githubusercontent.com/115066278/217520756-d83ba3e1-b694-44b0-855b-5625e58f72b7.png)

  
