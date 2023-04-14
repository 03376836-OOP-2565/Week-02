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
![image](https://user-images.githubusercontent.com/115066285/232096478-b00bd968-74e7-4cad-9455-28cf0e0edd19.png)




## 16. หาค่าจากสมการทางคณิตศาสตร์

กำหนด ```a = 10, b = 20, x = 5, y = 2``
👉 ให้เขียนโปรแกรมเพื่อหาผลลัพธ์ของสมการต่อไปนี้

1. `a+b` 
![image](https://user-images.githubusercontent.com/115066285/232097507-3eed5ff4-57db-498e-9530-90d110a70855.png)
2. `x-b`
![image](https://user-images.githubusercontent.com/115066285/232098304-49efce2b-feb2-416e-a0a1-396257b9f7d7.png)
3. `x*b`
![image](https://user-images.githubusercontent.com/115066285/232113547-dc154b84-1baa-4914-b8e2-35438a8816d4.png)
4. `y/a`
![image](https://user-images.githubusercontent.com/115066285/232113762-b3a592ac-8c71-4c57-88c1-f51d6383f608.png)
5. `b%y`
![image](https://user-images.githubusercontent.com/115066285/232114044-b47c1957-c93c-428e-baa6-d68f599e0e83.png)
6. `y+10%x`
![image](https://user-images.githubusercontent.com/115066285/232114274-4f7d44db-295e-48e4-8335-d522dee52ca5.png)
7. `a/3*5`
![image](https://user-images.githubusercontent.com/115066285/232114504-fcefd9f4-fcc5-4600-9ab7-4296532bc05b.png)
8. `9/2*a`
![image](https://user-images.githubusercontent.com/115066285/232116254-6e64771d-94fc-4bab-8a09-051d43e43e09.png)
9.. `y%8`
![image](https://user-images.githubusercontent.com/115066285/232117530-a5dc1888-2f5a-472f-b0db-0bb3865b2281.png)
10. `100*x+y%2-a`
![image](https://user-images.githubusercontent.com/115066285/232117719-d12de732-086a-4be9-a8e0-757a4ebf1662.png)


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
![image](https://user-images.githubusercontent.com/115066285/232118849-63e56684-1a34-4ed3-a731-7f46827bd688.png)




👷 คำสั่ง ให้เขียนโปรแกรมคำนวณค่าเพื่อเติมลงในช่องว่างในตาราง
ตารางที่ 1 ระยะทางจากดวงอาทิตย์ถึงดาวเคราะห์ต่างๆ

| ดาวเคราะห์ | ระยะทางจากดวงอาทิตย์ | ระยะทางในหน่วย A.U. | เวลาของแสง (นาที)
|---|---|---|---|
| Mercury | 57,910,000 km | 35,983,606 mile | 5.2 minutes
| Venus | 108,200,000 km | 67,232,363 mile | 9.7 minutes
| Earth | 149,600,000 km | 92,957,130 mile | 13.4 minutes
| Mars | 227,940,000 km | 141,635,350 mile | 20.4 minutes
| Jupiter |  778,330,000 km | 483,631,840 mile | 69.7 minutes
| Uranus | 2,873,550,000 km | 1,785,541,189 mile | 257.4 minutes
| Neptune | 4,501,000,000 km | 2,796,791,736 mile | 403.3 minutes
| Pluto | 5,945,900,000 km | 3,694,610,971 mile | 532.7 minutes



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
![image](https://user-images.githubusercontent.com/115066285/232120989-360ac198-02f0-40f2-ac7e-ed9bd6b486d7.png)

  
