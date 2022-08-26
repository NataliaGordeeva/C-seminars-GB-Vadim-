// int num1 = 0;
// int num = 7;

// while(num1 < num)
// {
//     Console.WriteLine(num1);
//     num1+=2;
// }

//Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// int num = new Random().Next(10, 100);
// int num1 = num/10;
// int num2 = num%10;

// // Console.WriteLine(num);
// // Console.WriteLine(num1);
// // Console.WriteLine(num2);

// int max = num1;
// if (max > num2)
// {
//     max = num2;
// }
// Console.WriteLine(num);
// Console.WriteLine(max);

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 999);
// int num1 = num/100;
// int num3 = num%10;

// Console.WriteLine(num);
// Console.Write(num1);
// Console.Write(num3);

//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.34, 5 -> не кратно, остаток 4, 16, 4 -> кратно

// Console.Write("Введите число 1= ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2= ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = number1 % number2;
// if (result == 0)
// {
// Console.WriteLine("без остатка");
// }
// else
// {
// Console.WriteLine("Остаток деления =" + result);
// }

// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// Console.Write("Введите число = ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = number%7;
// int b = number%23;
// if( a== 0 && b == 0)
// {
//     Console.WriteLine("деление без остатка");
// }
// else
// {
//     Console.WriteLine("остаток от деления на 7 ="+ a + " и остаток от деления на 23 =" + b);
// }

//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// Console.Write("Введите число 1= ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2= ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2*number2 || number2 == number1*number1)
// {
//     Console.WriteLine("true");
// }
// else
// {
//     Console.WriteLine("false");
// }

string a = "урок";
string b = "один";
Console.WriteLine(a +" "+ b);