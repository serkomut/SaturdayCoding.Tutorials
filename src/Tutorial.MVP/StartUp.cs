using System;
using System.Windows.Forms;
using Tutorial.MVP.Model;
using Tutorial.MVP.Presenter;
using Tutorial.MVP.View;

namespace Tutorial.MVP
{
    public partial class StartUp : Form, IView
    {
        private SayiIslemPresenter presenter;
        public StartUp()
        {
            InitializeComponent();
            presenter= new SayiIslemPresenter(new SayiIslemModel(), this);
        }

        public event ViewHandler<IView> Chenged;
        public void ChangeValue(int val)
        {
            textBox1.Text = val.ToString();
        }

        private void btnSayiArttır_Click(object sender, EventArgs e)
        {
            presenter.SayiyiArttır();
        }

        private void btnSayiAzalt_Click(object sender, EventArgs e)
        {
            presenter.SayiyiAzalt();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                Chenged.Invoke(this, new ViewEventArgs(int.Parse(textBox1.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir sayı giriniz!");
            }
        }
    }
}
