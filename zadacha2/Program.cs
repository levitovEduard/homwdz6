﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x,y;



 
    if (k1==k2)
          
            
                Console.WriteLine ("Прямые паралелльные ");
            
  
    else  
    {
    
         x = (b2-b1) / (k1-k2);
         y = k1 * x + b1;
         Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
             