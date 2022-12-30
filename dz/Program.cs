public static class Lesson457
{
    static void Main()
    {
   
// Ввод чисел M и N

 Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SUM(m, n);

// Расчёт суммы чисел от M до N

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}
// Метод вывода чисел от M до N
      
void SUM(int m, int n)
    {
        Console.Write (SumMN(m - 1, n));
    }

}}
