namespace _25._Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2, 2];//rango=fxc=2x2=4
            string[,] nombres = new string[3, 2];
            char[,] caracteres = new char[2, 4];
            bool[,] banderas = new bool[2, 5];
            object[,] objetos = new object[2, 5];

            //Asignacion de vbalores con f,c

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;
            //numeros [1, 2] = 7; Error por indices fuera de los rangos

            //Recuperar datso alamacenados en una posición
            Console.WriteLine($"Valor almacenado en la posicion con indices 1,0: {numeros[1, 0]}");

            //declaracion e inicializacion de matrices con valores por defecto

            string[,] apellidos =
                {
                    {"Chica","Lopez","Álvarez" },
                    {"Patiño","Ciro","Botero" },
                    {"Duque","Carmona","Castaño"}
                };

            //Recorrer para alamacenar datos
            string[,] strings = new string[3, 2];
            for (int i = 0; i < 3; i++)//Recorrer las filas
            {
                for (int j = 0; j < 2; j++)//Recorrer las columnas
                {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posición con índices {i}, {j}:");
                    nombres[i, j] = Console.ReadLine();
                }
            }

            //Recorrer para recuperar sus datos

            for (int i = 0; i < nombres.GetLength(0); i++)//.GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < nombres.GetLength(1); j++)//.GetLenght(1) devuelve el números de columnas
                {
                    Console.WriteLine($"Nombre almacenado en la posición {i},{j}: {nombres[i, j]}");
                }
            }

            for (int i = 0; i < nombres.GetLength(0); i++)//.GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < nombres.GetLength(1); j++)//.GetLenght(1) devuelve el números de columnas
                {
                    Console.WriteLine($"{nombres[i, j]}  |");
                }
            }
            Console.WriteLine();
        }

    }
}
        
    

