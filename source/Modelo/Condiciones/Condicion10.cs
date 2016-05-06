﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion10 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            //          if (personas.FindAll(persona => persona.Name.Equals(Name.Saverio) && !persona.MouthAction.Equals(MouthAction.Canta))
            //                    .Count > 0)
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Español) && persona.Sneakers.Equals(Sneakers.Topper)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
