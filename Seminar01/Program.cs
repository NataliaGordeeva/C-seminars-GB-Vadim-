// найти квадратный корень числа
//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine());
//int sqr = number * number;

//Console.WriteLine(sqr);

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
//Console.WriteLine("Введите число 1 = ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число 2 = ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//if(number1 == number2*number2)
//{
  //  Console.WriteLine("первое число явл квадратом второго числа");
//}
//else
//{
  //   Console.WriteLine("первое число не явл квадратом второго числа");
//}

//Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Console.Write("Введите число = ");
// int numberDay = Convert.ToInt32(Console.ReadLine());

// if(numberDay<1 || numberDay>7)
// {
//     Console.WriteLine("Ошибка, введите еще раз");
// }
// if 
// (numberDay == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if 
// (numberDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if 
// (numberDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// if 
// (numberDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if 
// (numberDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if 
// (numberDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if 
// (numberDay == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

 Console.Write("Введите число = ");
 int number = Convert.ToInt32(Console.ReadLine());
 int numberNeg = number*(-1);

 while (numberNeg <= number)
 {
    Console.WriteLine(numberNeg);
    numberNeg++;
 }
