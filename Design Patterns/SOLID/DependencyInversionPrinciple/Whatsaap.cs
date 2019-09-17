using System;

namespace SOLID.DependencyInversionPrinciple
{
    public class Whatsaap : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Message from Whatsaap");
        }
    }
}
