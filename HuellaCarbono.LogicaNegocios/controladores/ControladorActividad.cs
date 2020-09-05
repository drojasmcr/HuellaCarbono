using HuellaCarbono.LogicaNegocios.modelos;
using HuellaCarbono.LogicaNegocios.persistencia;


namespace HuellaCarbono.LogicaNegocios.controladores
{
    public class ControladorActividad
    {        
        public Ente AgregarActividadAEnte(Ente ente, Actividad actividad)
        {
            return Repositorios.AgregarActividadAEnte(actividad, ente);
        }

        public Ente RemoverActividadDeEnte(Ente ente, Actividad actividad)
        {
            return Repositorios.RemoverActividadDeEnte(ente, actividad);
        }
        
    }
}
