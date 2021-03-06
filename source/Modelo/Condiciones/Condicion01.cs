﻿using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public class Condicion01 : ICondition //Cantidad de botines Adidas igual a 2
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Sneakers.Equals(Sneakers.Adidas)).Count == 2)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}