using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{ 
    internal class ClsMenu
    {
        private ClsTransacciones transacciones;

        public ClsMenu()
        {
            transacciones = new ClsTransacciones();
        }

        public void InicializarVectores()
        {
            // Llama al método correspondiente de la instancia de ClsTransacciones
            transacciones.InicializarVectores();

            Console.WriteLine("Vectores inicializados correctamente.");
        }

        public void IngresarPasoVehicular()
        {
            // Llama al método correspondiente de la instancia de ClsTransacciones
            transacciones.IngresarPasoVehicular();

            Console.WriteLine("Paso vehicular registrado correctamente.");
        }

        public void ConsultarVehiculosPorPlaca()
        {
            Console.Write("Ingrese el número de placa a consultar: ");
            string numeroPlaca = Console.ReadLine();

            // Llama al método correspondiente de la instancia de ClsTransacciones
            transacciones.ConsultarVehiculoPorPlaca(numeroPlaca);
        }

        public void ModificarVehiculoPorPlaca()
        {
            Console.Write("Ingrese el número de placa a modificar: ");
            string numeroPlaca = Console.ReadLine();

            // Llama al método correspondiente de la instancia de ClsTransacciones
            transacciones.ModificarVehiculoPorPlaca(numeroPlaca);
        }

        public void ReporteTodosLosDatos()
        {
            // Llama al método correspondiente de la instancia de ClsTransacciones
            transacciones.ReporteTodosLosDatos(ReporteTodosLosDatos);
        }
    }




}
    
