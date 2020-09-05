using HuellaCarbono.LogicaNegocios.modelos;
using HuellaCarbono.LogicaNegocios.persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.controladores
{
    public class ControladorEnte
    {
        public static Repositorios TodosLosRepositorios{ get; set; }
        public ControladorEnte()
        {
            if ( TodosLosRepositorios == null )
                TodosLosRepositorios = new Repositorios();
        }
        public int AgregarEnte ( Ente ente)
        {
            return TodosLosRepositorios.AgregarEnte(ente);
        }

        public Ente BuscarEnte ( Ente ente)
        {
            return TodosLosRepositorios.BuscarEnte(ente);
        }

        public List<Ente> ObtenerTodosLosEntes()
        {
            return TodosLosRepositorios.ObtenerEntes();
        }

        public List<Ente> ObtenerTodosLosEntes( Type tipoEnte)
        {
            return TodosLosRepositorios.ObtenerEntes(tipoEnte);
        }
    }
}
