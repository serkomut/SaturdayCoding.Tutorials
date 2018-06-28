using Tutorial.MVP.Model;
using Tutorial.MVP.View;

namespace Tutorial.MVP.Presenter
{
    public class SayiIslemPresenter
    {
        private readonly IModel model;
        private readonly IView view;

        public SayiIslemPresenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;

            this.view.Chenged += ViewChanged;
        }

        void ViewChanged(IView sender, ViewEventArgs e)
        {
            model.SetValue(e.value);
        }

        public void SayiyiArttır()
        {
            model.SayiyiArttir();
            view.ChangeValue(model.GetValue());
        }

        public void SayiyiAzalt()
        {
            model.SayiyiAzalt();
            view.ChangeValue(model.GetValue());
        }
    }
}