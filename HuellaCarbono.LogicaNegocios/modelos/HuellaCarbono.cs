using System;
using System.Collections.Generic;

namespace HuellaCarbono.LogicaNegocios.modelos
{
    public class HuellaCarbono
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Actividad> Actividades { get; set; }
        public float TotalHuellaCarbono { get; set; }
    }
}
