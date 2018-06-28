namespace Tutorial.WindsorExample.Infrastructure
{
    public interface IMessageSender : IGet
    {
        void SendMessage(string message);
    }
}