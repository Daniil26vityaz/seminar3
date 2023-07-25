// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task2()
{
    int numberX1 = Input("Введите координат X для первой точки: ");
    int numberY1 = Input("Введите координат Y для первой точки: ");
    int numberZ1 = Input("Введите координат Z для первой точки: ");
    int numberX2 = Input("Введите координат X для второй точки: ");
    int numberY2 = Input("Введите координат Y для второй точки: ");
    int numberZ2 = Input("Введите координат Z для второй точки: ");
    double distance = Math.Sqrt(Math.Pow(numberX2-numberX1,2)+Math.Pow(numberY2-numberY1,2)+Math.Pow(numberZ2-numberZ1,2));
    Console.WriteLine("Расстояние между двумя точками равно: " + distance);
}

Console.Clear();
Task2();
