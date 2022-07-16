void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(1, 100);
}

int[] AddressSwapArray(int[] firstCollection)
{
    int[] secondCollection = firstCollection;
    return secondCollection;
}

int[] GlobalSwapArray(int[] firstCollection)
{
    int[] secondCollection = new int[5];
    for (int i = 0; i < firstCollection.Length; i++) secondCollection[i] = firstCollection[i];
    return secondCollection;
}

void ChangingArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = collection[i] - i;
}

void PrintArray(int[] collection1, int[] collection2)
{
    Console.WriteLine("first array: " + "[" + string.Join(", ", collection1) + "]");
    Console.WriteLine("second array: " + "[" + string.Join(", ", collection2) + "]\n");
}

int[] firstArray = new int[5]; // Создаем первый пустой массив на 10 элементов
int[] secondArray = new int[5]; // Создаем второй пустой массив на 10 элементов
FillArray(firstArray); // Заполняем рандомными значениями от 1 до 99
PrintArray(firstArray, secondArray); // Выводим массивы на экран
Console.WriteLine("Address swapping...");
secondArray = AddressSwapArray(firstArray); // Передаем значения по ссылкам
PrintArray(firstArray, secondArray); // Выводим массивы на экран
Console.WriteLine("Changing an first array...");
ChangingArray(firstArray); // Вычитаем из элементов первого массива их индекс (второй не трогаем!)
PrintArray(firstArray, secondArray); // Выводим массивы на экран
Console.WriteLine("Global swapping...");
secondArray = GlobalSwapArray(firstArray); // Делаем глобальную копию массива
PrintArray(firstArray, secondArray); // Выводим массивы на экран
Console.WriteLine("Changing an first array...");
ChangingArray(firstArray); // Вычитаем из элементов первого массива их индекс (второй не трогаем!)
PrintArray(firstArray, secondArray); // Выводим массивы на экран
