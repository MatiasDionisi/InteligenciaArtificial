using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    public class Condicion02 : ICondition //Cantidad de botines Nike igual a 2
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Sneakers.Equals(Sneakers.Nike)).Count == 2)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}