namespace Design_Patterns.Creational_Patterns.Singleton
{
    public class Unico
    {
        private static Unico Instance;

        private Unico() { }

        public static Unico GetUnico()
        {
            if(Instance == null)
            {
                Instance = new Unico();
            }
            return Instance;
        }
    }
}
