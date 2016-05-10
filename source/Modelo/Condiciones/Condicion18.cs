using System.Collections.Generic;

namespace Modelo.Condiciones
{
    class Condicion18 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Aleman) && persona.Sneakers.Equals(Sneakers.Nike)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
