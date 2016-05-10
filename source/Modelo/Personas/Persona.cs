namespace Modelo
{
    public class Persona 
    {
        Name name;
        public Name Name
        {
            get { return name; }
        }
        Nationality nationality;
        public Nationality Nationality
        {
            get { return nationality; }
        }

       Sneakers sneakers;
       public Sneakers Sneakers
       {
           get { return sneakers; }
       }       

       public Persona(Name name, Nationality nationality, Sneakers sneakers)
       {
           this.name = name;
           this.nationality = nationality;
           this.sneakers = sneakers;
       }

       public override string ToString()
       {
           return string.Format("{0} es {1} y usa botines {2}", name.ToString(), nationality.ToString(), sneakers.ToString());
       }
   }

}
