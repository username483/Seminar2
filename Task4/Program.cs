//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23: 14 - нет, 161 - да

Console.Clear();
Console.WriteLine("Введите число ");
int numberA=int.Parse(Console.ReadLine());
Console.WriteLine(numberA % 7 == 0 && numberA % 23 == 0 ? "Кратно" : "Не кратно");

// && оператор "и"
// || оператор "или"