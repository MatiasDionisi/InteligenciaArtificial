using System.Collections.Generic;

namespace Modelo.Condiciones
{
    class Condicion10 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Español) && persona.Sneakers.Equals(Sneakers.Topper)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
