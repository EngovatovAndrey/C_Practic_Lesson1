int[] array = {12, 21, 32, 41, 54, 6, 77, 8, 99};
int n = array.Length; // Длинна массива array
int find = 77;
int index =0;

while (index < n )
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;                     // Прерывание цикла, чтобы не искать одинаковые элементы
  }
  index += 1;
}
