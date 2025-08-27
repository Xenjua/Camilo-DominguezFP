namespace _99.ParcialCondicionalesCamiloD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sexo = 0;
            int edad = 0;
            int ultimodigito = 0;

            Console.WriteLine("ingrese su sexo ( 1 = masculino, 2 = femenino):");
            sexo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el ultimo digito de su documento de identidad (0-9)");
            ultimodigito = Convert.ToInt32(Console.ReadLine());

            int grupo = 4; // profe no me deja colocar una letra pero el grupo 4 es el grupo D, perdon jsdjsadk//

            if (sexo == 2 && edad >= 16 && edad <= 20 &&
                (ultimodigito == 0 || ultimodigito == 4 || ultimodigito == 8))
            {
                grupo = 1;
            }
            else if (sexo == 1 && edad >= 18 && edad <= 22 &&
                 (ultimodigito == 1 || ultimodigito == 5 || ultimodigito == 9))
            {
                grupo = 1;
            }
            else if (sexo == 2 && edad >= 21 && edad <= 25 &&
                (ultimodigito == 3 || ultimodigito == 7))
            {
                grupo = 2;
            }
            else if (sexo == 1 && edad >= 23 && edad <= 26 &&
                     (ultimodigito == 2 || ultimodigito == 6))
            {
                grupo = 2;
            }
            else if (edad == 15)
            {
                Console.WriteLine("domina el idioma ingles? (1 = si, 0 = no):");
                int ingles = Convert.ToInt32(Console.ReadLine());
                if (ingles == 1)
                {
                    grupo = 3;
                }
            }
            if (grupo == 1)
             {
               Console.WriteLine("la persona pertenece al grupo A");
             }
            else if (grupo == 2)
             {
             Console.WriteLine("la persona pertenece al grupo B");
             }
            else if (grupo == 3)
            {
             Console.WriteLine("la persona pertenece al grupo C");
            }
            else
            {
             Console.WriteLine("la persona pertenece al grupo D");
             }
            }
        }
    }


        
    

