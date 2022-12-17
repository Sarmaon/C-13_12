// Массивы 3й пример использования. Заполнение массива и печати рандомными данными. Поиск
//и вывод искомого индекса. Для показа первого из повторяющихся чисел в массиве используем break.

void FillArray(int[]collection)

{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll) //void не возвращает данные, 
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0; //если не встречается не одного элемента, то заменяем присвоение = -1.

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);