Console.Clear();
Console.WriteLine("Введите первое число ");
int numberA=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB=int.Parse(Console.ReadLine());
Console.WriteLine(numberA % numberB == 0 ? "Кратно" : $"Не кратно, {numberA%numberB}");
