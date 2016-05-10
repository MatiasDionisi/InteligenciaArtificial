using System.Collections.Generic;

namespace Modelo.Condiciones
{
    public interface ICondition
    {
        double valueFromPersona(List<Persona> personas);
    }
}
