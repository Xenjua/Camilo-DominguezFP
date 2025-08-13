namespace _4._CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
  

            string nombre = "";
            int sueldo = 0;
            int edad = 0;


            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingreser el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo>=3000)
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else 
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no iba abonar impuesos");

                /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,
   se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”*/

                Console.WriteLine("ingrese la edad");
                edad = Convert.ToInt32(Console.ReadLine());


                if (edad > 18)
                {
                    Console.WriteLine("Bienvenido a mi sitio web");
                }

                /*Crear un algoritmo que permita ingresar dos numeros, si el primer numero es mayor al segundo numero 
                 informar su suma y diferencia, en caso de lo contrario informar el producto y la division del primer numero respecto al segundo numero*/
                


        {
            
            {
                        Console.Write("Ingrese el primer número: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese el segundo número: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());

                        if (n1 > n2)
                        {
                            Console.WriteLine("Suma: " + (n1 + n2));
                            Console.WriteLine("Diferencia: " + (n1 - n2));
                        }
                        else
                        {
                            Console.WriteLine("Producto: " + (n1 * n2));
                            if (n2 != 0)
                                Console.WriteLine("División: " + (n1 / n2));
                            else
                                Console.WriteLine("No se puede dividir entre cero.");
                        }
                    }
                }
            }
        }

    }


        }
    


