﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Avion : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Enciendo el Avion";
        }

        public override string Detener()
        {
            return "Apago el Avion";
        }
    }
}
