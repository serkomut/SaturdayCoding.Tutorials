namespace Tutorial.WindsorExample.Infrastructure
{
    public interface ILoger : IGet
    {
        void WriteLog(string message);
    }

    public interface IGet { }
}