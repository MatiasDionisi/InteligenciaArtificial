using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion08 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Name.Equals(Name.Alves) && !persona.Nationality.Equals(Nationality.Uruguayo)).Count > 0 &&
                personas.FindAll(persona => persona.Name.Equals(Name.Alves)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}