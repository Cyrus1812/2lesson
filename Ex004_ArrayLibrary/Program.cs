void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// void - метод который не возвращает какие-либо значения 
// 1 void - заполняет массив случайными числами в данном случае от 1 до 20
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// 2 void - выводит все значения элементов в массиве

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если элемент не найден то результат выведет -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Остановить поиск после нахождения 1 искомого числа
        }
        index++;
    }
    return position;// Позиция элемента
} // Добавили метод

int[] array = new int[10]; //new int[10] - создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
// строки 27 и 28 показывают с каким именно массивом производить действия записанные в void
Console.WriteLine(); // Пустая строка для разделения рандомносгенерированных чисел и искомого числа

int pos = IndexOf(array, 4); // Результат работы метода IndexOf
Console.WriteLine(pos);