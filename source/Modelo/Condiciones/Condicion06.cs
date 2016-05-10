using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion06 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Name.Equals(Name.Alves) && persona.Sneakers.Equals(Sneakers.Adidas)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}