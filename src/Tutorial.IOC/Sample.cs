namespace Tutorial.IOC
{
    public class Sample
    {
        readonly IDisplayer displayer;
        string msg;

        public string Msg { get { return msg; } set { msg = value; } }

        public Sample()
        {
            displayer = null;
            this.msg = "";
        }

        public Sample(IDisplayer displayer)
        {
            this.displayer = displayer;
        }

        public void Test()
        {
            displayer.Display(msg);
        }
    }
}