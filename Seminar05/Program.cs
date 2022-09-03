// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11

// int num = 11;
// string resalt=Convert.ToString(num);

// int sum =(int) char.GetNumericValue(resalt[0]);
// Console.WriteLine(sum);


Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum =0;
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}
GetSum(num);
Console.WriteLine(GetSum(num));