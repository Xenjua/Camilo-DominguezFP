namespace _6.CondicionalMultIipleterciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorCompra = 0;
            float descuento = 0;
            char dia =  ' ';

            Console.WriteLine("Ingrese el valor de compra");

            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingresae el dia de la semana: l:lunes, m:martes, x:miercoles, j:jueves, v:viernes, s: sabado, d:domingo");
            dia=Convert.ToChar(Console.ReadLine());

            switch (dia)

            {
                case 'l':
                    descuento = valorCompra*0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");

                    break;
                 case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break ;
                case 'v':
                    descuento = valorCompra * 0.3f;
                    Console.WriteLine($"Hoy es viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break ;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sabado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break ;
                case 'd':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break ;
                default:
                    Console.WriteLine("valor no valido");
                    break ;
            }
        }
    }
}
