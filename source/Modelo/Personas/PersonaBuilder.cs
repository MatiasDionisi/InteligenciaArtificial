using System;

namespace Modelo.Personas
{
    [Serializable]
    class PersonaBuilder
    {
        private static PersonaBuilder instance;
        int Indice;
        string Nombre;
        string Nacionalidad;
        string Botines;

        private PersonaBuilder() { }

        public static PersonaBuilder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonaBuilder();
                }
                return instance;
            }
        }

        public void configurar(int indice, string nacionalidad, string botines, string nombre)
        {
            Indice = indice;
            Botines = botines;
            Nacionalidad = nacionalidad;
            Nombre = nombre;
        }

        public Persona build()
        {
            var nombre = Convert.ToInt32(Nombre, 2);
            var nacionalidad = Convert.ToInt32(Nacionalidad, 2);
            var botines = Convert.ToInt32(Botines, 2);
            return new Persona((Name)nombre, (Nationality)nacionalidad, (Sneakers)botines);
        }

    }
}
