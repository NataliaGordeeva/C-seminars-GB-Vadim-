// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);

// if (num>=10000 && num<100000)
// {
//     if(result[0]==result[4] && result[1]==result[3])
//     Console.WriteLine("true");
//     else 
//     Console.WriteLine("false");
// }
// else
// Console.WriteLine("введите еще раз ");

// напишите программу,которая на ввод принимает число А и выдает сумму чисел от 1 до А (7->28, 4->10)

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("сумма = "+GetSum(num));

// int GetSum(int number)
// {
//     int sum=0;
//     int count=0;

//     while(number>count)
//     {
//        count++;
//        sum+=count;
//     }
//     return sum;

// напишите программу, которая принимает на вход число и выдает колличество цифр в числе

// 1 путь от студентов (не рабочий)
// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("колличество = "+NumberAmount(result));

// int NumberAmount (string num)
// {
//     int size = num.Lenght;
//     return size;
// }
//2 путь
// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("колличество = "+GetCount(num));


// int GetCount(int number)
// {
//     int count=0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Напишите программу, которая приминает на вход число N и выдает произведение чисел от 1 до N

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("произведение = "+GetMult(num));

// int GetMult (int number)
// {
//     int mult = 1;
//     int count = 0;
   
//     while (number>count)
//     {
//         count++;
//         mult *= count; 
//     }
//     return mult;
// }

// напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

//1 вариант студентов - два метода
// 

int[] array = new int[8]; //нулевой массив
// заполняем массив
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index<lenght)
    {
        collection[index]=new Random().Next(0, 2);
        index++;
    }
}
//выводим массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(col[position]+ " ");
        position++;
    }

}
FillArray(array);
PrintArray(array);



// 2 вариант препода - один метод

// int [] array = GetArray(8);
// Console.WriteLine(string.Join(",",array));

// int [] GetArray(int size);     //вызов масива
// {
//     int [] result = new int [size];
//     for(int i=0; i<size; i++)
//     {
//         result[i]=new Random().Next(0,2);

//     }
//     return result;
// }

   