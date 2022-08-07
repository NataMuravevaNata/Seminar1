Console.WriteLine("Введите заданное число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Проверяем кратно ли второе число заданному");
if (n%m==0)
{
   Console.WriteLine("Да, кратно"); 
}
else
{
    Console.WriteLine("Нет, не кратно");
    int y = (n % m);
    Console.WriteLine("Остаток от деления равен:");
    Console.WriteLine (y);
}
