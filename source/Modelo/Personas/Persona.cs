using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

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
/*      MouthAction mouthAction;
        public MouthAction MouthAction
        {
            get { return mouthAction; }
        }
        Vehicle vehicle;
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
*/
       Sneakers sneakers;
       public Sneakers Sneakers
       {
           get { return sneakers; }
       }       

/*     public Persona(Name name, Nationality nationality, MouthAction mouthAction, Vehicle vehicle)
       {
           this.name = name;
           this.nationality = nationality;
           this.mouthAction = mouthAction;
           this.vehicle = vehicle;
       }
*/
       public Persona(Name name, Nationality nationality, Sneakers sneakers)
       {
           this.name = name;
           this.nationality = nationality;
           this.sneakers = sneakers;
       }

/*     public override string ToString()
       {
           return string.Format("{0} es {1} y {2} en su {3}", name.ToString(), nationality.ToString(), mouthAction.ToString(), vehicle.ToString());
       }
   }
*/

       public override string ToString()
       {
           return string.Format("{0} es {1} y usa botines {2}", name.ToString(), nationality.ToString(), sneakers.ToString());
       }
   }

}
