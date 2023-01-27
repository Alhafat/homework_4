// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

// // Вариант 1

int NumberPowB(int numberA)
{   
    int result=1;
    int numberB=int.Parse(Console.ReadKey().KeyChar.ToString());
    if (numberB>0)
    {
        for (int i=0; i<numberB; i++)
        {
            result*=numberA;
        }
    }
    else if (numberB==0) result=1;
    // else if (B<0) 
    // {
    //     result=number*(1/Math.Abs(B));
    // }
    return (result);
}

Console.Write("Введите число: ");
int numberA=int.Parse(Console.ReadLine()!);
Console.Write($"Число {numberA} в степени ");
int result=NumberPowB(numberA);
Console.WriteLine($" = {result} ");


// // Вариант 2

// Console.Clear();
// int NumberAToPownumberB(int numberA, int numberB)
// {   
//     int result=1;
//     if (numberB>0)
//     {
//         for (int i=0; i<numberB; i++)
//         {
//             result*=numberA;
//         }
//     }
//     else if (numberB==0) result=1;
//     // else if (B<0) 
//     // {
//     //     result=number*(1/Math.Abs(B));
//     // }
//     return (result);
// }

// Console.Write("Введите число: ");
// int numberA=int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень числа: ");
// int numberB=int.Parse(Console.ReadLine()!);
// int result=NumberAToPownumberB(numberA, numberB);
// Console.Write($"Число {numberA} в степени {numberB} = {result}");