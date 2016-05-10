using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion05 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Name.Equals(Name.Rakitic) && !persona.Nationality.Equals(Nationality.Aleman)).Count > 0 &&
                personas.FindAll(persona => persona.Name.Equals(Name.Rakitic)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}