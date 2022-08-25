//Напишите программу, которая берет на вход 2 числа
//и выдает, является ли второе число кратным первому
//Если число 2 не кратно первому, выводится остаток от деления
// 34,5 - не кратно, остаток 4; 16б4 - кратно

Console.Clear();
Console.WriteLine("Введите первое число ");
int numberA=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB=int.Parse(Console.ReadLine());
int numberC=numberA%numberB;
if (numberC==0)
{
    Console.WriteLine($"{numberA}, {numberB} - кратно");
}
else
{
    Console.WriteLine($"{numberA}, {numberB} - не кратно. остаток {numberC}");
}
