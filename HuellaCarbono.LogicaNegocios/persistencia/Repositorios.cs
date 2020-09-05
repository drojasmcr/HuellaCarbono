using HuellaCarbono.LogicaNegocios.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.persistencia
{
    public class Repositorios
    {
        public List<Ente> RepositorioEntes { get; set; }
        public List<Actividad> RepositorioActividades { get; set; }

        public Repositorios()
        {
            
        }

        public void InicializarRepositorios()
        {
            RepositorioEntes = new List<Ente>();
            RepositorioActividades = new List<Actividad>();
        }
    }
}
