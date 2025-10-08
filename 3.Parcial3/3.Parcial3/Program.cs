namespace _3.Parcial3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            {
                const int FILAS = 5;   
                const int COLS = 7;   

                int[,] ventas = new int[FILAS, COLS];
                string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

                Console.WriteLine("=== Gestión de Ventas Semanales ===\n");
                Console.WriteLine($"Ingresa ventas (enteros >= 0) para {FILAS} almacenes y {COLS} días.\n");

                
                for (int i = 0; i < FILAS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        ventas[i, j] = LeerEnteroNoNegativo(
                            $"Almacén {i + 1}, {dias[j]}: "
                        );
                    }
                    Console.WriteLine();
                }

                
                Console.WriteLine("\n--- Matriz de ventas (unidades) ---");
                Console.Write("Alm/Día".PadRight(10));
                foreach (var d in dias) Console.Write(d.PadLeft(10));
                Console.WriteLine();

                for (int i = 0; i < FILAS; i++)
                {
                    Console.Write(("Almacén " + (i + 1)).PadRight(10));
                    for (int j = 0; j < COLS; j++)
                        Console.Write(ventas[i, j].ToString().PadLeft(10));
                    Console.WriteLine();
                }

                
                Console.WriteLine("\n--- Promedio semanal por almacén ---");
                double maxProm = double.MinValue;
                int idxMaxProm = -1;

                for (int i = 0; i < FILAS; i++)
                {
                    int suma = 0;
                    for (int j = 0; j < COLS; j++) suma += ventas[i, j];

                    double promedio = (double)suma / COLS;
                    Console.WriteLine($"Almacén {i + 1}: {promedio:F2}");

                    if (promedio > maxProm)
                    {
                        maxProm = promedio;
                        idxMaxProm = i;
                    }
                }

                
                double promedioLunes = PromedioColumna(ventas, FILAS, 0);
                double promedioViernes = PromedioColumna(ventas, FILAS, 4);
                Console.WriteLine($"\nPromedio de ventas del Lunes (col 0): {promedioLunes:F2}");
                Console.WriteLine($"Promedio de ventas del Viernes (col 4): {promedioViernes:F2}");

                
                Console.WriteLine($"\nAlmacén con mayor promedio: Almacén {idxMaxProm + 1} ({maxProm:F2})");

                int idxDiaMax = -1;
                int totalDiaMax = int.MinValue;

                for (int j = 0; j < COLS; j++)
                {
                    int total = 0;
                    for (int i = 0; i < FILAS; i++) total += ventas[i, j];

                    if (total > totalDiaMax)
                    {
                        totalDiaMax = total;
                        idxDiaMax = j;
                    }
                }

                Console.WriteLine($"Día con mayores ventas totales: {dias[idxDiaMax]} (total = {totalDiaMax})");
               
                Console.ReadKey();
            }

            
            static int LeerEnteroNoNegativo(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string? s = Console.ReadLine();
                    if (int.TryParse(s, out int valor) && valor >= 0)
                        return valor;

                    Console.WriteLine("  * Valor inválido. Ingresa un entero mayor o igual a 0.");
                }
            }

            
            static double PromedioColumna(int[,] m, int filas, int col)
            {
                int suma = 0;
                for (int i = 0; i < filas; i++) suma += m[i, col];
                return (double)suma / filas;
            }
        }

    }
}
 
