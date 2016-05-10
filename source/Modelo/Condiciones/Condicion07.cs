using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion07 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Uruguayo) && persona.Sneakers.Equals(Sneakers.Adidas)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}