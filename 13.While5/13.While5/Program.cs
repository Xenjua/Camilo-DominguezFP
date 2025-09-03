namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int cantidadPares = 0;
            int rango = 0;

            Console.WriteLine("Ingrese el rango de numeros a evaluar:");
            rango = int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    cantidadPares++;

                }
                contador++;



            }
            Console.WriteLine($"La cantidad de numeros pares del 1 hasta {rango}, es: {cantidadPares}");


        }
    }
}
