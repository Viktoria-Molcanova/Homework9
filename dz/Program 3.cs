public static class Lesson457
{
    static void Main()
    {
   
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 
 //Ввод чисел M и N

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkerFunc(m,n);

// Метод вычисления функции Аккермана

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}

//  Вывод результатов

void AkkerFunc(int m, int n)
{
    Console.Write(Akker(m, n)); 
}
}}
