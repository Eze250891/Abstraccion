using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Coche : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Enciendo el motor del auto";
        }

        public override string Detener()
        {
            return "Apago el motor del auto";
        }
    }
}
