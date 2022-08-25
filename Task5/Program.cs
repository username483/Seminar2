// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
// 5, 25 -> да
//25, 5 -> да
//8,9 -> нет

Console.Clear();
Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine());

int min = A>B ? B:A;
int max = B>A ? B:A;
Console.WriteLine(min*min == max ? "да" : "нет");