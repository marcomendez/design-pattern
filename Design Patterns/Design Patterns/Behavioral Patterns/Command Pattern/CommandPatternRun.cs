using System;

namespace Design_Patterns.Behavioral_Patterns.Command_Pattern
{
    public class CommandPatternRun
    {
        public void run()
        {
            Console.WriteLine("************************** Command pattern **********************************");
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);
            AlquilerStock alquilerStock = new AlquilerStock(abcStock);


            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);
            broker.takeOrder(alquilerStock);

            broker.placeOrders();
        }
    }
}
