namespace Design_Patterns.Behavioral_Patterns.Command_Pattern
{
    class AlquilerStock : Order
    {
        private Stock abcStock;

        public AlquilerStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.alquiler();
        }
    }
}
