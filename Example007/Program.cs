Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int a = (n % 100);
Console.WriteLine( a );
Console.WriteLine("Вторая цифра введенного трехзначного числа:");
int b = (a / 10);
Console.Write( b );
