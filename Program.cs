// Вывести массив заданной длины, заполненный случайными числами от 0 до 9

Console.WriteLine("Введите длинну массива");
int L = int.Parse(Console.ReadLine());

int [] array = new int [L];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

PrintArray(array);