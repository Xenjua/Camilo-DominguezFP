namespace _27._Ejercicios_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*27. Desarrolla una aplicación que realice las siguientes tareas: 
            Solicita al usuario que ingrese las dimensiones de una matriz (número de filas y columnas). 
            Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
            Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros. 
            Finalmente, muestra por pantalla los totales obtenidos para cada categoría (positivos, negativos y ceros)*/

            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            int positivos = 0, negativos = 0, ceros = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0)
                        positivos++;
                    else if (matriz[i, j] < 0)
                        negativos++;
                    else
                        ceros++;
                }
            }

            Console.WriteLine($"\nTotal de positivos: {positivos}");
            Console.WriteLine($"Total de negativos: {negativos}");
            Console.WriteLine($"Total de ceros: {ceros}");
        }
    }
}
        
    

