using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class Cargo
    {
        public int cod_cargo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Cargo(int cod_cargo, string nombre, string descripcion)
        {
            this.cod_cargo = cod_cargo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public Cargo()
        {

        }

    }
}
