﻿Console.Write("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if(number < 0)
 {
    number = -number;
 }
 int lastNumber = 0;
 if(number > 99 && number < 1000)
 {
    lastNumber = number % 10;
    Console.Write($"Последняя цифра числа {number} равна {lastNumber}");
 }
 else
 {
    Console.Write("Число не трехзначное");
 }