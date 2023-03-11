using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class ClsTransacciones
    {
        private const int TAM = 100; // Tamaño máximo de los vectores

        // Vectores para almacenar los datos
        private string[] numFactura = new string[TAM];
        private string[] numPlaca = new string[TAM];
        private DateTime[] fecha = new DateTime[TAM];
        private TimeSpan[] hora = new TimeSpan[TAM];
        private int[] tipoVehiculo = new int[TAM];
        private int[] numCaseta = new int[TAM];
        private double[] montoAPagar = new double[TAM];
        private double[] pagaCon = new double[TAM];
        private double[] vuelto = new double[TAM];
        private int numRegistros = 0; // Número de registros actualmente almacenados

        public void InicializarVectores()
        {
            // Asigna los vectores numéricos con el valor cero y los vectores de tipo cadena con un espacio en blanco
            for (int i = 0; i < TAM; i++)
            {
                numFactura[i] = "";
                numPlaca[i] = "";
                fecha[i] = new DateTime();
                hora[i] = new TimeSpan();
                tipoVehiculo[i] = 0;
                numCaseta[i] = 0;
                montoAPagar[i] = 0;
                pagaCon[i] = 0;
                vuelto[i] = 0;
            }

            numRegistros = 0; // Reinicia el número de registros
        }

        public void IngresarPasoVehicular()
        {
            Console.WriteLine("\nIngrese los datos del paso vehicular:");

            // Pide los datos al usuario
            Console.Write("Número de factura: ");
            numFactura[numRegistros] = Console.ReadLine();

            Console.Write("Número de placa: ");
            numPlaca[numRegistros] = Console.ReadLine();

            Console.Write("Fecha (dd/mm/aaaa): ");
            fecha[numRegistros] = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Hora (hh:mm): ");
            hora[numRegistros] = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de vehículo:");
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Vehículo liviano");
            Console.WriteLine("3. Camión o pesado");
            Console.WriteLine("4. Autobús");
            Console.Write("Selección: ");
            tipoVehiculo[numRegistros] = int.Parse(Console.ReadLine());

            Console.Write("Número de caseta (1, 2 o 3): ");
            numCaseta[numRegistros] = int.Parse(Console.ReadLine());

            // Calcula el monto a pagar según el tipo de vehículo
            switch (tipoVehiculo[numRegistros])
            {
                case 1:
                    montoAPagar[numRegistros] = 0.50;
                    break;
                case 2:
                    montoAPagar[numRegistros] = 1.00;
                    break;
                case 3:
                    montoAPagar[numRegistros] = 2.00;
                    break;
                case 4:
                    montoAPagar[numRegistros] = 3.00;
                    break;
            }

            Console.WriteLine($"Monto a pagar: {montoAPagar[numRegistros]:C}");

            Console.Write("Paga con: ");
            pagaCon[numRegistros] = double.Parse(Console.ReadLine());
        }
        public void ConsultarVehiculoPorPlaca(string placa)
        {
            bool encontrado = false;
            for (int i = 0; i < numRegistros; i++)
            {
                if (numPlaca[i] == placa)
                {
                    Console.WriteLine($"Número de factura: {numFactura[i]}");
                    Console.WriteLine($"Número de placa: {numPlaca[i]}");
                    Console.WriteLine($"Fecha: {fecha[i]:dd/MM/yyyy}");
                    Console.WriteLine($"Hora: {hora[i]:hh\\:mm}");
                    Console.WriteLine($"Tipo de vehículo: {tipoVehiculo[i]}");
                    Console.WriteLine($"Número de caseta: {numCaseta[i]}");
                    Console.WriteLine($"Monto a pagar: {montoAPagar[i]:C}");
                    Console.WriteLine($"Paga con: {pagaCon[i]:C}");
                    Console.WriteLine($"Vuelto: {vuelto[i]:C}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontró ningún vehículo con la placa {placa}");
            }
        }

        public void ModificarVehiculoPorPlaca(string placa)
        {
            bool encontrado = false;
            for (int i = 0; i < numRegistros; i++)
            {
                if (numPlaca[i] == placa)
                {
                    Console.WriteLine("Ingrese los nuevos datos:");

                    Console.Write("Número de factura: ");
                    numFactura[i] = Console.ReadLine();

                    Console.Write("Fecha (dd/mm/aaaa): ");
                    fecha[i] = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    Console.Write("Hora (hh:mm): ");
                    hora[i] = TimeSpan.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de vehículo:");
                    Console.WriteLine("1. Moto");
                    Console.WriteLine("2. Vehículo liviano");
                    Console.WriteLine("3. Camión o pesado");
                    Console.WriteLine("4. Autobús");
                    Console.Write("Selección: ");
                    tipoVehiculo[i] = int.Parse(Console.ReadLine());

                    Console.Write("Número de caseta (1, 2 o 3): ");
                    numCaseta[i] = int.Parse(Console.ReadLine());

                    // Recalcula el monto a pagar según el tipo de vehículo
                    switch (tipoVehiculo[i])
                    {
                        case 1:
                            montoAPagar[i] = 0.50;
                            break;
                        case 2:
                            montoAPagar[i] = 1.00;
                            break;
                        case 3:
                            montoAPagar[i] = 2.00;
                            break;
                        case 4:
                            montoAPagar[i] = 3.00;
                            break;
                    }

                    Console.WriteLine($"Monto a pagar: {montoAPagar[i]:C}");

                    Console.Write("Paga con: ");
                    pagaCon[i] = double.Parse(Console.ReadLine());

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontró ningún vehículo con la placa {placa}");
            }
        }

        public void ReporteTodosLosDatos(Action reporteTodosLosDatos)
        {
            Console.WriteLine("\nReporte de todos los datos:");
            Console.WriteLine("N° Factura\tN° Placa\tFecha\t\tHora\t\tTipo de Vehículo\tCaseta\tMonto a pagar\tPaga con\tVuelto");
            for (int i = 0; i < numRegistros; i++)
            {
                Console.WriteLine($"{numFactura[i]}\t\t{numPlaca[i]}\t\t{fecha[i]:dd/MM/yyyy}\t{hora[i]:hh\\:mm}\t\t{tipoVehiculo[i]}\t\t\t{numCaseta[i]}\t\t{montoAPagar[i]:C}\t\t{pagaCon[i]}");
            }

        }




        }//end class
    }//end name space
