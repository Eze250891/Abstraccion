using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Coche : MedioTransporte
    {
        //Constructor por defecto () lo armas en el program
        public Coche() 
        {
        
        }

        // constructor donde definis el parametro dentro de los parentesis

        public Coche(int anioFabricacion)
        {
            AnioFabricacion = anioFabricacion;
        }

        //contructor con los dos metodos en los parentesis
        public Coche(int anioFabricacion, int capacidad)
        {
            AnioFabricacion = anioFabricacion;
            Capacidad = capacidad;
        }

        public override string Arrancar()
        {
            return "Enciendo el motor del auto";
        }

        public override string Detener()
        {
            return "Freno y apago el motor del auto";
        }
    }
}
