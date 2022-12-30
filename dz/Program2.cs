public static class Lesson457
{
    static void Main()
    {
   
 //Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 
 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumber(num, count);
//Метод поиска натуральных чисел и вывода результатов

void NaturalNumber(int a, int count)
{
    if (count > a)
    {
        return;
    }
    else
    {
        NaturalNumber(a, count + 1);
        Console.Write(count + " ");
    }
}
}}
