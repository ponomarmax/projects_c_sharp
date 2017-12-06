using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab4_mvc
{
    public interface IView
    {
        void Update_speed(int speed, double accelaration);
    }
    public partial class View_form : Form, IView
    {
        public Presenter Presenter { get; set; }
        
        public View_form(Presenter pr)
        {
            Presenter = pr;
            this.KeyPreview = true;
            this.InitializeComponent();
        }
        public void Update_speed(Int32 speed, double accelaration)
        {
            this.speed_box.Text = speed.ToString();
            this.textacceleration_box.Text = accelaration.ToString("f");
        }

        private void View_form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    groupBox1.Enabled = true;
                    break;
                case Keys.E:
                    Presenter.increase_speed();
                    break;
                case Keys.W:
                    Presenter.change_state(false);//fast stopping
                    Presenter.reduce_speed();
                    break;
            }
        }
        private void View_form_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    groupBox1.Enabled = false;
                    break;
                case Keys.E:
                    Presenter.change_state(true);
                    //we've stopped increase speed and turns start reduce slow
                    Presenter.reduce_speed();
                    break;
                case Keys.W:
                    //determine whether after breaking engine could reduce speed slow or it must stop
                    Presenter.change_state(Presenter.can_i_go());
                    Presenter.reduce_speed();
                    break;
            }
        }
        #region radiobuttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на первой скорости";
            Presenter.change_switch(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на второй скорости";
            Presenter.change_switch(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на третьей скорости";
            Presenter.change_switch(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на четвертой скорости";
            Presenter.change_switch(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на пятой скорости";
            Presenter.change_switch(5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            message_label.Text = "Вы на нейтральной скорости";
            Presenter.change_switch(0);
        }
        #endregion

        private void View_form_Load(object sender, EventArgs e)
        {

        }
    }
}
