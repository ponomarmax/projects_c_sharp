using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_mvc
{

    public class Presenter
    {
        Timer t_speed_up, t_speed_down, t_speed_slow;

        public Model Model { get; private set; }
        public View_form View { get; private set; }
        public Presenter(Model model)
        {

            Model = model;
            View = new View_form(this);

            t_speed_down = new Timer();//when slow down
            t_speed_up = new Timer();// when gas
            t_speed_slow = new Timer(); // when leave a pedal

            t_speed_up.Interval = 100;
            t_speed_down.Interval = 100;
            t_speed_slow.Interval = 1000;

            t_speed_up.Tick += SpeedUp;
            t_speed_down.Tick += SpeedDown;
            t_speed_slow.Tick += reduce_speed_slow;
        }

        public void change_state(bool state)//slow and fast slow down state
        {
            Model.state = state;
        }
        public bool can_i_go()// to control boundaries in switch
        {
            return Model.can_i_change_speed(1);
        }
        public void change_switch(int sw)
        {
            Model.Switch = sw;
        }
        #region Increase
        public void increase_speed()
        {
            if (Model.Switch != 0)
            {
                Model.Time = t_speed_up.Interval;//time for aceleration
                t_speed_down.Stop();
                t_speed_slow.Stop();
                t_speed_up.Start();
            }
            //this.Model.increase_speed();
        }
        public void SpeedUp(object sender, EventArgs e)
        {
            if (Model.can_i_change_speed())
            {
                Model.IncreaseSpeed();//0.0 for exclude integer division
                
            }
            else
            {
                reduce_speed();
                Model.Aceleration = 0;
            }
            View.Update_speed(Model.Speed, Model.Aceleration);
        }
        #endregion
        public void reduce_speed()
        {
            if (Model.state) //determine whether engine exists in allow speed's range, 
                             //other words, engine could run or not
            {
                Model.Time = t_speed_slow.Interval;
                t_speed_up.Stop();
                t_speed_down.Stop();
                t_speed_slow.Start();
            }
            else
            {
                Model.Time = t_speed_down.Interval;
                t_speed_slow.Stop();
                t_speed_down.Start();
            }
        }
        public void reduce_speed_slow(object sender, EventArgs e)
        {
            if (Model.can_i_change_speed(1))//1 is a boundary coundition
                SpeedDown(sender, e);
            else
            {
                t_speed_slow.Stop();
                t_speed_down.Start();
            }
        }

        public void SpeedDown(object sender, EventArgs e)
        {
            if (Model.Speed > 0)
            {
                Model.DecreaseSpeed();
                if (Model.Speed == 0)
                    Model.Aceleration = 0;
                //Notify_all_speed();
                View.Update_speed(Model.Speed, Model.Aceleration);

            }
            else
                t_speed_down.Stop();
        }
    }
}
