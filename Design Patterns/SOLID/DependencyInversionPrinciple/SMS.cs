using System;

namespace SOLID.DependencyInversionPrinciple
{
    public class SMS : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Message from SMS");
        }
    }
}
