using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder_Pattern
{
    public class RunBuilder
    {
        public void Run()
        {
            Console.WriteLine("************************** Builder Pattern **********************************");
            Persona persona = new Persona.Builder("marco")
           .setColegio("flamingo")
           .setEdad(301)
           .SetMunicipio("santa cruz")
           .SetLastName("Mendez")
           .build();


            Console.WriteLine("Name " + persona.name);
            Console.WriteLine("Colegio " + persona.Colegio);
            Console.WriteLine("Edad " + persona.Edad);
            Console.WriteLine("Municipio " + persona.Municipio);
            Console.WriteLine("Last Name" + persona.LasName);
            Console.WriteLine("*****************************************************************************");
        }
    }
}
