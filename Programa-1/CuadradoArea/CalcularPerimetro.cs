namespace Programas.CuadradoArea
{
    public class CalcularPerimetro
    {
        public  void CalcularCuadrado()
        {
            int lado = 0;
            int perimetro = 0;

            try
            {
                Console.WriteLine("Digite el valor del lado del cuadrado: ");
                lado = Convert.ToInt32(Console.ReadLine());

                perimetro = lado * 4;

                Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al calcular el perimetro");
               
            }
           
        }

        public void CalcularSumaProducto()
        {
                int num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int suma = 0;
                int producto = 0;

            try
            {
                Console.WriteLine("Digite el primer número entero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el segundo número entero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el tercer número entero: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el cuarto número entero: ");
                num4 = Convert.ToInt32(Console.ReadLine());

                suma = (num1 + num2);
                producto = (num3 * num4);

                Console.WriteLine($"Resultado de la suma de los dos primeros números: {suma}");
                Console.WriteLine($"Resultado del producto del tercer y cuarto número: {producto}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al realizar las operaciones" );

            }


        }

        public void CalcularPromedio()
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal num4 = 0;
            decimal Suma = 0;
            decimal Promedio = 0;

            Console.WriteLine("Digite el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite el tercer número: ");
            num3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite el cuarto número: ");
            num4 = Convert.ToDecimal(Console.ReadLine());

            Suma = (num1 + num2 + num3 + num4);
            Promedio = (Suma / 4);

            Console.WriteLine($"Resultado de la suma de los números: {Suma}");
            Console.WriteLine($"Resultado del promedio: {Promedio}");

        }


    }
}
