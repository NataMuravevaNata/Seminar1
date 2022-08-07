Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int a = ((n / 10)-(n%100/10)+(n%10));
Console.WriteLine( a );

