// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("Сколько элементов будем в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[n];
int i=0;
while (i<firstArray.Length) 
    {
        Console.WriteLine($"введите {i}-й элемент массива:");
        firstArray[i]=Console.ReadLine();
        i++;
    }
Console.WriteLine("Ваш массив:");
PrintArray (firstArray);
void PrintArray(string[] array) 
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountStringLessThreeChar(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

int countFirst = CountStringLessThreeChar(firstArray);
string[] resultFirst =  FillResultArray(firstArray,countFirst);
Console.Write ("Ваш новый массив: ");
 PrintArray(resultFirst);

