using HuellaCarbono.LogicaNegocios.modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HuellaCarbono.LogicaNegocios.persistencia
{
    public static class Repositorios
    {
        public static List<Ente> RepositorioEntes = new List<Ente>();


        public static int AgregarEnte(Ente ente)
        {
            if (ente.MisActividades == null)
                ente.MisActividades = new List<Actividad>();
            RepositorioEntes.Add(ente);
            return 1;
        }

        public static Ente RemoverActividadDeEnte(Ente ente, Actividad actividad)
        {
            var _ente = RepositorioEntes.Find(item => item.Nombre == ente.Nombre);
            _ente.MisActividades.RemoveAll(item => item.Descripcion == actividad.Descripcion);
            return _ente;
        }

        public static Ente BuscarEnte(Ente ente)
        {
            return RepositorioEntes.Find(item => item.Nombre == ente.Nombre );
        }


        public static Ente AgregarActividadAEnte(Actividad actividad, Ente ente)
        {
            Ente _ente = BuscarEnte(ente);
            _ente.MisActividades.Add(actividad);
            ActualizarEnte(_ente);
            return _ente;
        }

        public static List<Ente> ObtenerEntes()
        {
            return RepositorioEntes;
        }

        public static List<Ente> ObtenerEntes(Type type)
        {
            return RepositorioEntes.FindAll(item => item.GetType() == type);
        }
        public static int ActualizarEnte(Ente ente)
        {
            RemoverEnte(ente);
            return AgregarEnte(ente);
        }

        public static int RemoverEnte( Ente ente )
        {
            return RepositorioEntes.RemoveAll(item => item.Nombre == ente.Nombre);
        }
    }
}
