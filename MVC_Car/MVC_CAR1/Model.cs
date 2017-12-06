using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_mvc
{
    public class Model
    {
        int prev_speed;
        public bool state { get; set; }
        public int Speed { get; set; }
        public int Time { get; set; }
        public double Aceleration { get; set; }
        public int Switch { get; set; }

        public Model()
        {
            prev_speed = 0;
            Speed = 0;
            Time = 1;
            Aceleration = 0;
            Switch = 0;
            state = true;
        }

        public bool can_i_change_speed(int boundary_condition = 0)
        {//boundary_condition exists for reduce (fast or low) speed and has value 1
         //needed for correct work on the lowest and the highest boarder
            switch (Switch)
            {
                case 1:
                    return Speed >= 0 + boundary_condition && Speed < 20 + boundary_condition;
                case 2:
                    return Speed >= 10 + boundary_condition && Speed < 40 + boundary_condition;
                case 3:
                    return Speed >= 25 + boundary_condition && Speed < 60 + boundary_condition;
                case 4:
                    return Speed >= 45 + boundary_condition && Speed < 80 + boundary_condition;
                case 5:
                    return Speed >= 60 + boundary_condition && Speed < 100 + boundary_condition;
            }
            return false;
        }
        public void IncreaseSpeed()
        {
            prev_speed = Speed;
            Speed += 1;
            Aceleration = (Speed - prev_speed) * (10000 / 36.0) / Time;
        }
        public void DecreaseSpeed()
        {
            prev_speed = Speed;
            Speed -= 1;
            
            Aceleration = (prev_speed - Speed) * (10000 / 36.0) / Time;
        }
    }
}
