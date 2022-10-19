// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Clear();

int Print(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Print(m-1, 1);
    return Print(m-1,Print(m, n-1));

}

Console.WriteLine("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для заданных значений равна: {Print(m, n)}");
