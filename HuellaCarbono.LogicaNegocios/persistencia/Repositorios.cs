using HuellaCarbono.LogicaNegocios.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.persistencia
{
    public class Repositorios
    {
        public static List<Ente> RepositorioEntes { get; set; }
        public static List<Actividad> RepositorioActividades { get; set; }

        public Repositorios()
        {
            InicializarRepositorios();
        }

        public void InicializarRepositorios()
        {
            RepositorioEntes = new List<Ente>();
            RepositorioActividades = new List<Actividad>();
        }

        public int AgregarEnte(Ente ente)
        {
            RepositorioEntes.Add(ente);
            return 1;
        }

        public Ente BuscarEnte(Ente ente)
        {
            return RepositorioEntes.Find(item => item.Nombre == ente.Nombre );
        }

        public int AgregarActividad( Actividad actividad)
        {
            RepositorioActividades.Add(actividad);
            return 1;
        }
    }
}
