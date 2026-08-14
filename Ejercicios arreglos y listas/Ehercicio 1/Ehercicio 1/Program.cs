int[] numero = new int[3];
numero[1] = 1;
numero[2] = 2;
numero[0] = 3;
int suma = 0;

for (int i = 0; i < 3; i++)
{
    suma = suma + numero[i];
}
Console.WriteLine($"La suma de los valores del arreglo es de {suma}");