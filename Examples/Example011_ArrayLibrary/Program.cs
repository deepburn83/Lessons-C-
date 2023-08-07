void FillArray(int[] collection)
//void - метод (функция), который не возвращает.
// при этом, в конце, не используется команда return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index +1;
    }
}

 void PrintArray(int[] col) // метод void, который будет печатать массив
 {
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 }

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
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

int[] array = new int[10]; //Создание массива длиной 10 элементов

FillArray(array); // метод, заполняющий массив числами
array[4] = 4;
array[6] = 4;
PrintArray(array); //метод, распечатывающий массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);