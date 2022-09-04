// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11

// int num = 11;
// string resalt=Convert.ToString(num);

// int sum =(int) char.GetNumericValue(resalt[0]);
// Console.WriteLine(sum);


// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSum(int number)
// {
//     int sum =0;
//     while(number>0)
//     {
//         sum+=number%10;
//         number/=10;
//     }
//     return sum;
// }
// GetSum(num);
// Console.WriteLine(GetSum(num));

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//сумма отрицательных равна -20.

// int[] array = new int[12];
// int size = array.Length;

// int positiveSum = 0;
// int negativeSum = 0;

// for(int i=0; i<size; i++)
// {
// array[i]=new Random().Next(-9, 10);
// if(array[i]>0)
// {
//     positiveSum+=array[i];
// }
// else
// {
//     negativeSum+=array[i];
// }

// }
// Console.WriteLine("сумма положительных ="+"  "+positiveSum+";"+"сумма отрицательных ="+negativeSum);
// Console.WriteLine(String.Join(";",array));

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и тд. Результат запишем в новом массиве.[12345]->583

int [] inputArray={1,2,3,4,5};
// int index=inputArray.Length;

int [] resultArray=new int[inputArray.Length/2+inputArray.Length%2];
for(int i=0;i<resultArray.Length;i++)
{
    resultArray[i]=inputArray[i]*inputArray[inputArray.Length-1-i];
    if(i==inputArray.Length-1-i)
    {
        resultArray[i]=inputArray[i];
    }
}
Console.WriteLine(String.Join(",",resultArray));
