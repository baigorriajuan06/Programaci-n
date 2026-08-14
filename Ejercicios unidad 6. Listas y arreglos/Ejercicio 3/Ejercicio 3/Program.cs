int[] num = new int[5];

num[0] = 7;
num[1] = 3;
num[2] = 2;
num[3] = 4;
num[4] = 9;

Console.WriteLine("El arreglo de izquiera a derecha es: ");
foreach (int i in num)
{
    Console.WriteLine(i);
}

Array.Reverse(num);

Console.WriteLine("El arreglo de derecha a izquiuerda es: ");
foreach (int i in num)
{
    Console.WriteLine(i);
}