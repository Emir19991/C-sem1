﻿

Console.WriteLine("Введите число A:");
      int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
     int b = Convert.ToInt32(Console.ReadLine());
 
if(a == b * b)
{
   Console.WriteLine("Является ли первое число квадрат второго");
   Console.WriteLine("Yes");
}
          
 else
{
    Console.WriteLine("No");
}