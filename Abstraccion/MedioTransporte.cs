using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class MedioTransporte
    {
        //Atributo
        public int AnioFabricacion { get; set; } 

        public int Capacidad { get; set; }



        //Metodos
        public abstract string Arrancar();
        public abstract string Detener();
        
    }
}
