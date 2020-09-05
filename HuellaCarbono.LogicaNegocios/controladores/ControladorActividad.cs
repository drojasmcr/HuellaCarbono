using HuellaCarbono.LogicaNegocios.modelos;
using HuellaCarbono.LogicaNegocios.persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.controladores
{
    public class ControladorActividad
    {
        Repositorios repositorios = new Repositorios();
        public Ente AgregarActividadAEnte(Ente ente, Actividad actividad)
        {
            return repositorios.AgregarActividadAEnte(actividad, ente);
        }

        public Ente RemoverActividadDeEnte(Ente ente, Actividad actividad)
        {
            return repositorios.RemoverActividadDeEnte(ente, actividad);
        }
    }
}
