//работа с массивами №2

int[] array = {11, 222, 333, 444, 555, 66, 444, 88, 99, 12};

int n = array.Length;
int find = 444;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //в случае повтороения чисел, останавливает на первом по порядку
    }
    // index = index +1; тоже самое что index++
    index++;
}

