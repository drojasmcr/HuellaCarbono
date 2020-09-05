using HuellaCarbono.LogicaNegocios.modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HuellaCarbono.LogicaNegocios.persistencia
{
    public class Repositorios
    {
        public static List<Ente> RepositorioEntes { get; set; }

        public Repositorios()
        {
            InicializarRepositorios();
        }

        public void InicializarRepositorios()
        {
            RepositorioEntes = new List<Ente>();            
        }

        public int AgregarEnte(Ente ente)
        {
            RepositorioEntes.Add(ente);
            return 1;
        }

        internal Ente RemoverActividadDeEnte(Ente ente, Actividad actividad)
        {
            var _ente = RepositorioEntes.Find(item => item.Nombre == ente.Nombre);
            _ente.MisActividades.RemoveAll(item => item.Descripcion == actividad.Descripcion);
            return _ente;
        }

        public Ente BuscarEnte(Ente ente)
        {
            return RepositorioEntes.Find(item => item.Nombre == ente.Nombre );
        }


        public Ente AgregarActividadAEnte(Actividad actividad, Ente ente)
        {
            Ente _ente = BuscarEnte(ente);
            _ente.MisActividades.Add(actividad);
            ActualizarEnte(_ente);
            return _ente;
        }

        internal List<Ente> ObtenerEntes()
        {
            return RepositorioEntes;
        }

        public List<Ente> ObtenerEntes(Type type)
        {
            return RepositorioEntes.FindAll(item => item.GetType() == type);
        }
        public int ActualizarEnte(Ente ente)
        {
            RemoverEnte(ente);
            return AgregarEnte(ente);
        }

        public int RemoverEnte( Ente ente )
        {
            return RepositorioEntes.RemoveAll(item => item.Nombre == ente.Nombre);
        }
    }
}
