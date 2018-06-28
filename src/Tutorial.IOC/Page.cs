using System;

namespace Tutorial.IOC
{
    public class Page : IDisplayer
    {
        public void Display(string s)
        {
            Console.WriteLine("" + s + "");
        }
    }
}