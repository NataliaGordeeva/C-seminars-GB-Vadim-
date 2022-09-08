// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)[1 2 3 4 5] -> [5 4 3 2 1], [6 7 3 6] -> [6 3 7 6]

// int [] array = GetArray (10,0,10);
// Console.WriteLine(String.Join(",",array));

// ReversArray(array);
// Console.WriteLine(String.Join(",",array));

// int [] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int [size];
// for(int i=0; i<size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue+1);

// }
// return res;

// }

// void ReversArray(int [] inArray)
// {
// for(int i=0; i<inArray.Length/2; i++)
// {
// int k = inArray[i];
// inArray[i] = inArray[inArray.Length-1-i];
// inArray[inArray.Length-1-i] = k;

// }
// }

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// 1-ый вариант - нерабочий
// bool GetNumber(int num1, int num2, int num3);
// {
//     if(num1>num2+num3)
//     return false;
//     else
//     if(num2>num1+num3)
//     return false;
//     else
//     if(num3>num1+num2)
//     return false;
//     else return true;
// }

// bool Triangle=GetNumber(10,4,5);
// if (Triangle==true)
// {
//     Console.WriteLine("треугольнику быть");
// }
// else
// {
//     Console.WriteLine("треугольнику не быть");
// }

// 2-ой вариант - рабочий
// Console.WriteLine("Ввежите стороны треугольника (a,b,c) = ");
// double num1=Convert.ToDouble(Console.ReadLine());
// double num2=Convert.ToDouble(Console.ReadLine());
// double num3=Convert.ToDouble(Console.ReadLine());

// void CheckTrial (double a, double b, double c)
// {
//     if(a<(b+c) && b<(a+c) && c<(a+b))
//     {
//         Console.WriteLine("false");
//     }
//     else
//     {
//         Console.WriteLine("true");
//     }
// }
// CheckTrial(num1,num2,num3);

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101, 3 -> 11, 2 -> 10

// 1 способ (встроенная функция)
// int value = 10;
// string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

// 2 способ - препод
// void ConvertNum(int number)
// {
//     string result="";
//     while(number>0)
//     {
//         result=number%2+result;
//         number/=2;
//     }
//   Console.WriteLine(result);
// }
// int input=Convert.ToInt32(Console.ReadLine());
// ConvertNum(input);

// int num =4+3; ответ 7
// string str = "4"+"3"; ответ 43

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// вариант1
Console.WriteLine("введите число = ");
int num=Convert.ToInt32(Console.ReadLine());
int firstN=0;
int secondN=1;
Console.Write(firstN+" ");
Console.Write(secondN+" ");

for(int i=3; i<=num; i++)
{
    int newN=firstN+secondN;
    Console.Write(newN+" ");
    firstN=secondN;
    secondN=newN;

}