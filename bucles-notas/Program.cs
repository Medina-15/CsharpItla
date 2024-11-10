namespace bucle_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BucleDnotas();
        }

        private static void BucleDnotas()
        {
            Console.WriteLine("Este programa muestra que cantidad de estudiantes aprobo y reprobo, donde se aprueba con una nota de 7 en adelante");

            // Declarando variables

            int nota = 0;
            int cantidadDnotas = 0;
            int aprobados = 0;
            int reprobados = 0;
            string valor = string.Empty;



            // Obteniendo la cantidad de repeticiones del bucle

            Console.WriteLine("Ingrese la cantidad de notas");
            valor = Console.ReadLine();

            if (int.TryParse(valor, out cantidadDnotas)) // Validando si es un valor entero
            {
                for (int i = 1; i <= cantidadDnotas; i++)
                {
                    Console.WriteLine($"Ingrese la nota {i}");
                    valor = Console.ReadLine();                    
                    
                    if (int.TryParse(valor, out nota))
                    {
                        if (nota >= 7)
                        {
                            aprobados++;
                        }

                        else
                        {
                            reprobados++;
                        }

                    }

                    else
                    {
                        Console.WriteLine("El formato ingresado no es correcto");
                    }

                }

                Console.WriteLine($"La cantidad de aprobados es: {aprobados} y la cantidad de reprobados es: {reprobados}");

            }
            else
            {
                Console.WriteLine("El formato ingresado no es correcto");
            }
                


          

                
            

        }
    }
}