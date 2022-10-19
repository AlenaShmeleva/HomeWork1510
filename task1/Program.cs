//  Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

int Print(int m, int n)
{
    if (n == m)
        return n;
    return n + Print(m, n-1);

}

Console.WriteLine("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от первого до второго значения равна: {Print(m, n)}");