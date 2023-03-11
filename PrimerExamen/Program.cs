using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsMenu menu = new ClsMenu();

            int opcion = 0;

            do
            {
                Console.WriteLine("=== MENÚ ===");
                Console.WriteLine("1. Inicializar vectores");
                Console.WriteLine("2. Ingresar paso vehicular");
                Console.WriteLine("3. Consultar vehículos por placa");
                Console.WriteLine("4. Modificar vehículo por placa");
                Console.WriteLine("5. Reporte de todos los datos");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu.InicializarVectores();
                        break;
                    case 2:
                        menu.IngresarPasoVehicular();
                        break;
                    case 3:
                        menu.ConsultarVehiculosPorPlaca();
                        break;
                    case 4:
                        menu.ModificarVehiculoPorPlaca();
                        break;
                    case 5:
                        menu.ReporteTodosLosDatos();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor seleccione una opción del menú.");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);

        }//end main


    }// end class
}
