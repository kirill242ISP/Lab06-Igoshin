// // // Задание 1.1
// // for (int i = 10; i >= 1; i--)
// // {
// //     Console.WriteLine(i);
// // }
// // Задание 1.2
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// // Задание 2
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }

//     if (i % 7 == 0)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine($"Сумма кратных 3: {sum}");
// Console.WriteLine($"Количество кратных 7: {count}");

// // Задание 3
// int polozitelCount = 0;
// int otrisatelCount = 0;

// Console.WriteLine("Введите числа, чтобы закончить введите 0:");
// int chislo = Convert.ToInt32(Console.ReadLine());

// while (chislo != 0)
// {
//     if (chislo > 0)
//     {
//         polozitelCount = polozitelCount + 1;
//     }
//     else if (chislo < 0)
//     {
//         otrisatelCount  = otrisatelCount +1;
//     }

//     chislo = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {polozitelCount}");
// Console.WriteLine($"Отрицательных чисел: {otrisatelCount}");

// Задание 4
// bool isPasswordCorrect = false;
// for (int popitka = 1; popitka <= 3; popitka++)
// {
//     Console.Write("Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == "kirillkrytoi")
//     {
//         isPasswordCorrect = true;
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
// }

// if (!isPasswordCorrect)
// {
//     Console.WriteLine("Доступ заблокирован");
// }
// // Задание 5
// Console.Write("Введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }
// Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

// // Итоговая задача. «Угадай число»
// int otvet = 242;
// bool win = false;

// Console.WriteLine("Игра: Угадай число от 1 до 300! У вас есть 10 попыток.");

// for (int popitka = 1; popitka <= 10; popitka++)
// {
//     Console.Write($"Попытка {popitka}. Введите число: ");
//     int vvod = Convert.ToInt32(Console.ReadLine());

//     if (vvod == otvet)
//     {
//         Console.WriteLine($"Вы угадали! Попыток: {popitka}");
//         win = true;
//         break;
//     }
//     else if (vvod < otvet)
//     {
//         Console.WriteLine("Больше");
//     }
//     else
//     {
//         Console.WriteLine("Меньше");
//     }
// }
// if (!win)
// {
//     Console.WriteLine($"Вы не угадали, число было {otvet}");
// }

// Дополнительное задание 
  Console.Write("Введите целое положительное число: ");
  int num = Convert.ToInt32(Console.ReadLine());
  int sumchisel = 0;
  int countchisel = 0;
  while (num > 0)
  {
      int lastDigit = num % 10;
      sumchisel += lastDigit;
      countchisel++;
      num = num / 10;
  }
  Console.WriteLine($"Сумма цифр: {sumchisel}");
  Console.WriteLine($"Количество цифр: {countchisel}");
