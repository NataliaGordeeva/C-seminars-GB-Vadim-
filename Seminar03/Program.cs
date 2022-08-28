// вывод 3 цифры числа
// string str = Console.ReadLine();
// if(str.Length<=2)
// {
//     Console.WriteLine("нет третьего числа");
// }
// Console.WriteLine(str[2]);

//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,в которой находится эта точка.

// Console.WriteLine("введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if(x>0 && y>0)
// {
//     Console.WriteLine(1);
// }
// if(x>0 && y<0)
// {
//     Console.WriteLine(4);
// }
// if(x<0 && y>0)
// {
//     Console.WriteLine(2);
// }
// if(x<0 && y<0)
// {
//     Console.WriteLine(3);
// }
// if(x==0 || y==0)
// {
//     Console.WriteLine("false");
// }

//Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

// Console.WriteLine("введите номер четверти оси координат = ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a==1)
// {
//  Console.WriteLine("x>0, y>0");
// }
// if(a==2)
// {
//  Console.WriteLine("x<0, y>0");
// }
// if(a==3)
// {
//  Console.WriteLine("x<0, y<0");
// }
// if(a==4)
// {
//  Console.WriteLine("x>0, y<0");
// }
// if (a<=0 || a>=5)
// {
//     Console.WriteLine("false");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//  в 2D пространстве.A (3,6); B (2,1) -> 5,09 | A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("x1"+" "+"y1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("x2"+" "+"y2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

// Console.WriteLine(d);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25. 2 -> 1,4

Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a< N)
{
    Console.Write(Math.Pow(a,2)+" ");
    a++;
} 
// for (int count = 1; count<=number; count++)
//  {
// double result = Math.Pow(count, 2);
// Console.WriteLine(result);
// }