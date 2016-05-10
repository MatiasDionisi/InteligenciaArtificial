using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion18 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
//          if (personas.FindAll(persona => persona.Name.Equals(Name.Baltasar) && !persona.Vehicle.Equals(Vehicle.Bicicleta))
//              .Count > 0)
//          {
//              retorno = (double)Valores.VALIDO;
//          }
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Aleman) && persona.Sneakers.Equals(Sneakers.Nike)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
