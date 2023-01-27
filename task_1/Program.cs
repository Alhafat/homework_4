// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int NumberPowB(int number, int B)
{   
    int result=1;
    return(B);
    if (B>0)
    {
        for (int i=0; i<B; i++)
        {
            result*=number;
        }
    }
    else if (B==0) result=1;
    // else if (B<0) 
    // {
    //     result=number*(1/Math.Abs(B));
    // }
    return (result);
}

Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int B=int.Parse(Console.ReadLine()!);
int result=NumberPowB(number,B);
// int b=NumberPowB(B);
Console.WriteLine($"Число {number} в степени {B}  = {result}");