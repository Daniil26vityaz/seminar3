// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task3()
{
    int number = Input("Введите положительное число: ");
    int counter = 1;
    if (number > 0)
    {
        while (counter <= number)
        {
            Console.WriteLine($"куб числа {counter} = {Math.Pow(counter, 3)}");
            counter++;
        }
    }
    else
    {
        Console.WriteLine("Введенное число меньше или равно нулю");
    }

}
Console.Clear();
Task3();
