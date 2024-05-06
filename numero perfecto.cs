void perfec()
{
    Console.WriteLine("ingrese un numero: ");
    int x = Convert.ToInt32(Console.ReadLine());

    List<int> num = new List<int>();
    for (int i=1; i<x; i++)
    {
        int r = x % i;
        if (r==0)
        {
            num.Add(i);
        }
    }
    int suma = num.Sum();
    if (suma == x)
    {
        Console.WriteLine($"{x} es perfecto");
    }
    else
    {
        Console.WriteLine($"{x} no es perfecto");
    }
}
perfec();
