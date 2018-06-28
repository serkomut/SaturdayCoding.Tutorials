using System;
using System.ComponentModel;

namespace Tutorial.IOC
{
    public class Screen: IDisplayer
    {
        public void Display(string s)
        {
            Console.WriteLine(s);
        }
    }
}
