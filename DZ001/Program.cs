//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n]; 

void FillArrayNumbers(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
FillArrayNumbers(n); 
int PositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
  
Console.WriteLine($"Количество чисел больше 0: {PositiveNumbers(array)}");

//void PositiveNumbers()

//{
//    Console.Write("Введите числа через пробел: ");
//    int [] array = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0) count++;
//    }
//    Console.WriteLine($"Количество чисел больше 0: {count}");
//}

//PositiveNumbers();