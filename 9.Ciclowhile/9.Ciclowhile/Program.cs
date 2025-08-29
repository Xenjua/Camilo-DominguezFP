namespace _9.Ciclowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"C:{contador} -A: {acumulador}");
                contador++;




            }
            Console.WriteLine($"la suma de los cinco primeros numeros enteros es: {acumulador}");

            

        }
    }
}
