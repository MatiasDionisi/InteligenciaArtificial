﻿using System.Collections.Generic;

namespace Modelo.Condiciones
{
    class Condicion11 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Name.Equals(Name.Fressi) && !persona.Nationality.Equals(Nationality.Español)).Count > 0 &&
                personas.FindAll(persona => persona.Name.Equals(Name.Fressi)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
