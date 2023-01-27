// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int Summ(int number)
{   
    int summ=0;
    while (number>0)
    {
        summ=summ+number%10;
        number=number/10;
    }
    return (summ);
}

Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine()!);
int summ=Summ(number);
Console.WriteLine($"Сумма цифр числа {number} = {summ}");