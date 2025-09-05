using System.Security.Cryptography.X509Certificates;

namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //17. nuevo ejercicio:

            int numtabla = 0;
            int multiplicador =1;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un numero para calcular su tabla de multiplicar:");
                numtabla = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{ numtabla} x { multiplicador} = { numtabla*multiplicador}");
                    multiplicador++;


                } while (multiplicador <= 10);
                multiplicador = 1;
                Console.WriteLine("Desea otra tabla de multiplicar: s:si, n:no");
                respuesta = Console.ReadLine().ToLower();





            } while (respuesta == "s");

        }
    }
}
