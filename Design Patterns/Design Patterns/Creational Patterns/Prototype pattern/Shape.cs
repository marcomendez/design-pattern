using System;

namespace Design_Patterns.Creational_Patterns.Prototype_pattern
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void draw();

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = Clone();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return clone;
        }
    }
}
