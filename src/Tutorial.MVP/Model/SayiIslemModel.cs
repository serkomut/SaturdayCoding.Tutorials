using Tutorial.MVP.View;

namespace Tutorial.MVP.Model
{
    public class SayiIslemModel : IModel
    {
        private int value;
        public void SayiyiArttir()
        {
            value++;
        }

        public void SayiyiAzalt()
        {
            value--;
        }

        public void SetValue(int v)
        {
            value = v;
        }

        public int GetValue()
        {
            return value;
        }
    }
}