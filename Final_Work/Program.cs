/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых менее либо равна 3.
Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

// метод для создания массива
string[] CreateArray(int length)
{
    string[] strings = new string[length];
    return strings;
}

// Метод для печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("  " + array[i]); 
    }
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] strings = CreateArray(length);
Console.WriteLine("Введите массив: ");
for (int count = 0; count < strings.Length; count++)
{
    strings[count] = Console.ReadLine()+"";
}

Console.WriteLine("Исходный массив: ");
PrintArray(strings);

string[] newstrings = CreateArray(length);
int n = 0; 
for (int count = 0; count < newstrings.Length; count++) 
{
    if (strings[count].Length <= 3)
    {
        newstrings[n] = strings[count];
        n++;
    }
}
 
Array.Resize(ref newstrings ,n+1);
Console.WriteLine("\nРезультирующий массив: ");
PrintArray(newstrings);

