using System;

namespace HuellaCarbono.LogicaNegocios.modelos
{
    public class Actividad
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public decimal FactorEmision { get; set; }
        public Unidad UnidadDeActividad { get; set; }
    }
}
