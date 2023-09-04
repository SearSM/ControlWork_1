// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length - 1; i++)
    {
        Console.Write($"”{massive[i]}”, ");
    }
    Console.Write($"”{massive[massive.Length - 1]}”]");
}

string[] MakeFinalArray(string[] massive, int size)
{
    string[] finalMassive = new string[size];

    int index = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            finalMassive[index] = massive[i];
            index++;
        }
    }
    return finalMassive;
}

int GetSizeNewArray(string[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] array = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
int sizeNewArray = GetSizeNewArray(array);
string[] finalArray = MakeFinalArray(array, sizeNewArray);
PrintArray(array);
Console.Write(" -> ");
PrintArray(finalArray);