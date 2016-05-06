﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion15 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
//          if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Turco) && !persona.MouthAction.Equals(MouthAction.Recita))
//              .Count > 0 && personas.FindAll(persona => persona.Nationality.Equals(Nationality.Turco)).Count == 1)
            if (personas.FindAll(persona => persona.Name.Equals(Name.Fressi) && !persona.Nationality.Equals(Nationality.Croata)).Count > 0 &&
                personas.FindAll(persona => persona.Name.Equals(Name.Fressi)).Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
