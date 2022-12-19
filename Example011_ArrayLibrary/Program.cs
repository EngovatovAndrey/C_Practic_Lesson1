// void метод который ничего не возвращает 
// command + k сворачивает строки кода

void FillArray(int[] collection) // метод для заполнения массива случайными числами
{
    int length = collection.Length; // количество элементов
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

void PrintArray(int[] coll) // метод для печати массива постросчно 
{
    int count = coll.Length; // количество элементов
    int position = -1; // -1 чтобы выводить значение вне 
    // диапазона поиска, чтобы понять что его нет 
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position += 1;
    }
}

int IndexOf(int[] collection, int find) // метод возвращающий позицию
// в качестве аргумента принимает массив collection  
{
    int count = collection.Length; // определяем колличество аргументов
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // для остановки, после нахождения первого элемента
        }
        index += 1;
    }
    return position;
}
int[] array = new int[10]; // определили массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);




