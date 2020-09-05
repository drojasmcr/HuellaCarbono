using System;
using System.Collections.Generic;
using System.Text;

namespace HuellaCarbono.LogicaNegocios.modelos
{
    public abstract class Ente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public HuellaCarbono MiHuellaDeCarbono { get; set; }
        public List<Actividad> MisActividades { get; set; }
    }
}
