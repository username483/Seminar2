//Напишите программу, которая выводит случайное число из отрезка [10,99] 
//и показывает наибольшую цтфру этого числа
// Например 78 - 8
Console.Clear();
int numberA = new Random().Next(10,100);
int numberB = numberA/10;
int numberC = numberA%10;
if (numberC>numberB)
{
    Console.WriteLine($"{numberA}, {numberC}");
}
else
{
Console.WriteLine($"{numberA}, {numberB}");
}
