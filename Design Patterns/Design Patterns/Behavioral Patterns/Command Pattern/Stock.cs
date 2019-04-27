using System;

namespace Design_Patterns.Behavioral_Patterns.Command_Pattern
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity +" ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity +" ] sold");
        }

        public void alquiler()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity + " ] alquiler");
        }
    }
}
