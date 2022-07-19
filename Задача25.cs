/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Неккоректный ввод числа";

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
    }
    return result;
}

void Main(int x, int y)
{
  {
     Console.WriteLine(Math.Pow(x,y));
  }
   
}

int x = GetNumber("Введитче число");
int y = GetNumber("Введите степень");
Main(x, y);

