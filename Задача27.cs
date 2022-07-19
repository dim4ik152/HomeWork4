int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}

int GetSumm(int number)
{
  int result = 0;
        while (number > 0)
{
    result += number % 10;
    number = number / 10;
}
return result;
}

void Main()
{
    int myValue = GetNumber();
    int result = GetSumm(myValue);
    Console.WriteLine(result);

}

Main();

