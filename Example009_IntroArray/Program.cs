// Пример функции использующей аргумент в качестве массива 

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индекс массива 0, 1, 2,  3,  4, 5,  6, 7,  8
// gприсваивание нового значения по индексу массива
// array[0] = 11 меняет в массиве 12 на 11 
int[] array = {12, 21, 32, 41, 54, 6, 77, 8, 99};

int SuperMax = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(SuperMax);