using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Barco : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Enciendo el Barco calentando motores";
        }

        public override string Detener()
        {
            return "Apago el Barco tirando el ancla";
        }
    }
}
