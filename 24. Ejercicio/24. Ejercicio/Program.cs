﻿namespace _24._Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //24.Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo, al final, debe visualizar el promedio de esos números./

            int[] numeros = new int[10];
            int suma = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }


            double promedio = (double)suma / numeros.Length;

            Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio}");
        }
    }
}
        
    

