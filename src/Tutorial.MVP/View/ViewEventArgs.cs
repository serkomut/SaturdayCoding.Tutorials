using System;

namespace Tutorial.MVP.View
{
    public class ViewEventArgs : EventArgs
    {
        public int value;

        public ViewEventArgs(int v)
        {
            value = v;
        }
    }
}