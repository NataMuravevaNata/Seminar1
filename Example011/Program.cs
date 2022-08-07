Console.WriteLine("Введите заданное число");
int n = int.Parse(Console.ReadLine());
if (n<99)
{
   Console.WriteLine("В заданом числе нет третей цифры");
}
if (n<999)
{
    int m = (n % 10);
    Console.WriteLine("Третья цифра числа равена:");
    Console.WriteLine (m);
}    
   