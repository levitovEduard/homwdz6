//Пользователь вводит с клавиатуры M чисел через пробел . Посчитайте, сколько чисел больше 0 ввёл пользователь
    
        Console.WriteLine("Введите числа через пробел ");
        int m, num, count = 0;
        m = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < m; i++)

        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) count++;
            
        }

        Console.WriteLine($"Колличество чисел > 0 = {count}");
        