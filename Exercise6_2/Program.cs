/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/


string Peresechenie(double k1, double b1, double k2, double b2)

{
    string koordinata = "Точка пересечения двух прямых:  ";
    double x = (b2 - b1) / (k1 - k2);
    double y= k2 * x + b2;
    koordinata = koordinata + x + "," + y;
    return koordinata;

}

Console.WriteLine(" Для нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; ");
Console.Write(" Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

string koordinata = Peresechenie(k1, b1, k2, b2);
Console.Write(koordinata);
