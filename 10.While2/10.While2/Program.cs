namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un numero dado por el usario

            int num = 0;
            int contador = 1;
            int acumulador = 1;
            Console.WriteLine("Ingrese un numero para calcular factorial");
            num = int.Parse(Console.ReadLine());

            while (contador<=num)
            {
                acumulador=acumulador*contador;
                Console.WriteLine($"Contador: {contador} - factorial: {acumulador}");
                contador++;
                    
            }
            Console.WriteLine($"el factorial del numero {num}, es; {acumulador}");
           

        }
    }
}
