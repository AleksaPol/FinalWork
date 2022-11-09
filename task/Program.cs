
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

Console.WriteLine("Итоговая задача");
Console.WriteLine("Сколько элементов будет в массиве?");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int lim = 3;
string[] input = new string[size];
FillArray(input);
if (CountElementsOutputArray(input) == 0) { Console.WriteLine($"[{String.Join(", ", input)}] -> [ ]"); }
else
{
    string[] output = new string[CountElementsOutputArray(input)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (input[i].Length <= lim)
        {
            output[j] = input[i];
            j++;
        }
    }
    Console.WriteLine($"[{String.Join(", ", input)}] -> [{String.Join(", ", output)}]");
}
void FillArray(string[] input)
{
    Random random = new Random();
    string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int sizeElementInputArray = random.Next(1, 10);
        for (int j = 0; j < sizeElementInputArray; j++)
        {
            input[i] += Symbols[random.Next(0, Symbols.Length)];
        }
    }
}

int CountElementsOutputArray(string[] input)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (input[i].Length <= lim)
        {
            count++;
        }
    }
    return count;
}
