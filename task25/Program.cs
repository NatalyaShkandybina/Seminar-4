// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3,5 -> 243
// 2,4 -> 16
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int step = A;

for (int i = 1; i < B; i++)
{
    step = step * A;
}
Console.WriteLine("А в степени В равно:" + step);