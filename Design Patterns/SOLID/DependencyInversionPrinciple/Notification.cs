namespace SOLID.DependencyInversionPrinciple
{
    public class Notification
    {
        public void Send(IMessage message)
        {
            message.SendMessage();
        }
    }
}
