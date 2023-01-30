// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

// Вариант 1
// int count;

// Console.WriteLine("Введите число элементов массива: ");
// count = Convert.ToInt32(Console.ReadLine());

// int [] numbers = new int[count];

// Console.WriteLine("Введите поочередно значения массива:");

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i]=int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine(string.Join(", ", numbers));

// Вариант 2
// int[]ReadArray()
// {
//     Console.WriteLine("Введите поочередно значения массива:");
//     int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
//     return array;
// }

// int[] numbers=ReadArray();
// Console.WriteLine(string.Join(", ", numbers));


//Вариант 3
int[]ReadArray()
{
    int count;
    Console.WriteLine("Введите число элементов массива: ");
    count = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[count];
    Console.WriteLine("Введите поочередно значения массива:");
    array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    return array;
}

int[] numbers=ReadArray();
Console.WriteLine(string.Join(", ", numbers));