/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

string Bolshenyl(int a) 
{
    int sum = 0;
    int temp = 0;
    string stoka =string.Empty;
    string stoooka = "Чисел больше 0: ";
    for(int i=0; i<a; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        temp = Convert.ToInt32(Console.ReadLine());
        stoka += temp;

        if(temp > 0) sum += 1;
    }
    stoooka += sum;
    return stoooka;
}

Console.Write(" Введите какое количество чисел нужно проверить являются ли они больше 0:  ");
int size = Convert.ToInt32(Console.ReadLine());

string schetchik = Bolshenyl(size);
Console.Write(schetchik);
