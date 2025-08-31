using System;

class Program
{
    static void Main()
    {
        // Declaramos un arreglo de 5 enteros
        int[] numeros = { 10, 20, 30, 40, 50 };

        // Mostramos los elementos del arreglo
        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"numeros[{i}] = {numeros[i]}");
        }
    }
}
