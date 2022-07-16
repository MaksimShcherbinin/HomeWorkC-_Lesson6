int Filling (int count)
{
    int result = 0;
    for(int i = 1; i <= count; i++)
    {
        Console.Write("Введите {0}-е число: ", i);
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if(userNumber > 0) result++;    
    }
    return result;
}

Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чисел больше 0: {0} шт.", Filling(count));
