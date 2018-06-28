namespace Tutorial.MVP.View
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs args);
}