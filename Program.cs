//Задача 64: Задайте значение N. Напишите метод, 
//который выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
FillArray(number, array);
PrintArray(array);

void FillArray(int number, int[] array, int count = 0)
{
    if (count + 1 > number)
    {
        return;
    }
    array[count] = count + 1;
    count++;
    FillArray(number, array, count);
}

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($" {i}");
    }
}  