using System;

namespace Design_Patterns.Creational_Patterns.Builder_Pattern
{
    public class Persona
    {
        public string name;
        public string Municipio;
        public string Colegio;
        public int Edad;
        public string LasName;

        private Persona() { }

        public  class Builder
        {
            Persona persona;
            public Builder(string name)
            {
                persona = new Persona();
                persona.name = name;
            }

            public Builder SetMunicipio(string municipio)
            {
                persona.Municipio = municipio;
                return this;
            }

            public Builder SetLastName(string lastname)
            {
                persona.LasName = lastname;
                return this;
            }

            public Builder setColegio(string colegio)
            {
                persona.Colegio = colegio;
                return this;
            }

            public Builder setEdad(int edad)
            {
                persona.Edad = edad;
                return this;
            }

            public Persona build()
            {
                return persona;
            }
        }
    }
}
