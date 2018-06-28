namespace Tutorial.MVP.View
{
    public interface IView
    {
        event ViewHandler<IView> Chenged;
        void ChangeValue(int val);
    }
}