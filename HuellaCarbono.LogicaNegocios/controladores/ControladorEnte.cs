using HuellaCarbono.LogicaNegocios.modelos;
using HuellaCarbono.LogicaNegocios.persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.controladores
{
    public class ControladorEnte
    {        
        public ControladorEnte()
        {
           
        }
        public int AgregarEnte ( Ente ente)
        {
            return Repositorios.AgregarEnte(ente);
        }

        public Ente BuscarEnte ( Ente ente)
        {
            return Repositorios.BuscarEnte(ente);
        }

        public List<Ente> ObtenerTodosLosEntes()
        {
            return Repositorios.ObtenerEntes();
        }

        public List<Ente> ObtenerTodosLosEntes( Type tipoEnte)
        {
            return Repositorios.ObtenerEntes(tipoEnte);
        }
    }
}
