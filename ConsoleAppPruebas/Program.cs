using System;
using HuellaCarbono.LogicaNegocios.controladores;
using HuellaCarbono.LogicaNegocios.modelos;
using HuellaCarbono.LogicaNegocios.persistencia;

namespace ConsoleAppPruebas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Lo declaro aqui porq es una aplicacionde consola, en una de windows se debe declarar
            //una vez por pantalla como se ve en la pantalla principal
            ControladorEnte controladorEnte = new ControladorEnte();
            //Agregar un ente
            var ente = new Empresa { Id = 1, Nombre = "Empresa 1" };
            controladorEnte.AgregarEnte(ente);
            //Agregar otro ente
            var ente2 = new Empresa { Id = 2, Nombre = "Empresa 2" };
            controladorEnte.AgregarEnte(ente2);
            //Desplegar todos los entes
            var listaEntes = controladorEnte.ObtenerTodosLosEntes();
            foreach (var item in listaEntes)
            {
                Console.WriteLine("Id del ente: {0} -- Nombre del ente: {1}", item.Id, item.Nombre);
            }

            //Agregar una actividad a un ente
            var actividad = new Actividad { Id = 1, Descripcion = "Consumo de electricidad", 
                FactorEmision = 0.0557, UnidadDeActividad = Unidad.KgCO2xKWH };

            //Agregar una actividad a un ente
            var actividad2 = new Actividad
            {
                Id = 2,
                Descripcion = "Transporte terrestre diesel",
                FactorEmision = 2.613,
                UnidadDeActividad = Unidad.KgCO2xLitro
            };

            ControladorActividad controladorActividad = new ControladorActividad();
            //Asocia la misma actividad a dos entes
            controladorActividad.AgregarActividadAEnte(ente, actividad);
            controladorActividad.AgregarActividadAEnte(ente, actividad2);
            

            //Desplegar actividades de un ente
            foreach (var item in ente.MisActividades)
            {
                Console.WriteLine("Actividad - Id: {0}, Descripciòn: {1}, Factor Emisiòn: {2}, Unidad: {3}",
                    item.Id, item.Descripcion, item.FactorEmision, item.UnidadDeActividad);
            }

        }
    }
}
