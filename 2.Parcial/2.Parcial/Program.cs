namespace _2.Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 20;
            int xd = 1;
            int trabajan = 0, estudian = 0;
            int mujeresTrabajan = 0, hombresEstudian = 0;

            while (xd <= total)
            {
                Console.WriteLine($"Estudiante {xd}:");
                Console.Write("Ocupación (trabaja/estudia): ");
                string ocupacion = Console.ReadLine().ToLower();
                Console.Write("Género (hombre/mujer): ");
                string genero = Console.ReadLine().ToLower();

                if (ocupacion == "trabaja")
                {
                    trabajan++;
                    if (genero == "mujer") mujeresTrabajan++;
                }
                else
                {
                    estudian++;
                    if (genero == "hombre") hombresEstudian++;
                }

                xd++;
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Porcentaje que trabajan: {(trabajan * 100) / total}%");
            Console.WriteLine($"Porcentaje que estudian: {(estudian * 100) / total}%");
            Console.WriteLine($"Número de mujeres que trabajan: {mujeresTrabajan}");
            Console.WriteLine($"Número de hombres que estudian: {hombresEstudian}");
        }
    }
}
    

