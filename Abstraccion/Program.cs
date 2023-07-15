namespace Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor con los parametros en parentesis
            Coche coche1 = new Coche(1990,5);


            Avion avion1 = new Avion()
            {
              AnioFabricacion = 2002,
              Capacidad = 200
            };

            Barco barco = new Barco()
            {
                AnioFabricacion = 1995,
                Capacidad = 500
            };

            var arrancarCoche = coche1.Arrancar();
            var detenerCoche = coche1.Detener();

            Console.WriteLine($"El coche arranca {arrancarCoche}");
            Console.WriteLine($"El coche se de detiene {detenerCoche}");

            Console.WriteLine("-----------------------------------");

            var encenderAvion = avion1.Arrancar();
            var detenerAvion = avion1.Detener();

            Console.WriteLine($"El avion se enciende {encenderAvion}");
            Console.WriteLine($"El avion se detiene {detenerAvion}");

            Console.WriteLine("-----------------------------------");


            var arrancarBarco = barco.Arrancar();
            var detenerBarco = barco.Detener();

            Console.WriteLine($"El barco enciende {arrancarBarco}");
            Console.WriteLine($"El barco apaga {detenerBarco}");


        }
    }
}