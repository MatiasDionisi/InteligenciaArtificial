﻿using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion04 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Name.Equals(Name.Rakitic) && persona.Sneakers.Equals(Sneakers.Nike)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}