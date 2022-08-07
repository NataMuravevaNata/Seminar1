Console.Write("Вставить случайное число n, ");
int n = int.Parse(Console.ReadLine ());
int a = (-n-1);
while (a<n-1)
{
        Console.Write( a );
        Console.Write(",");
    a=a+1;
}
Console.Write( n );
