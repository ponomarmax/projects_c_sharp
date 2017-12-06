using Lab5_Client.Ensure_Agent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5_Client
{
    public partial class Form1 : Form
    {
        int sum;
        decimal cost;
        public Form1()
        {
            InitializeComponent();
            sum = 1000;//min ensure summa
            cost = 0;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_passport.Text == "")
                {
                    label_status.Text = "Passport is empty. Please fill it";
                    return;
                }
                if (monthCalendar_from.SelectionStart >= monthCalendar_to.SelectionStart)
                {
                    label_status.Text = "End date must be bigger than start date";
                    return;
                }
                if (!Int32.TryParse(textBox_ensure_sum.Text, out sum) || sum < 1000 || sum > 100000)
                {
                    label_status.Text = "Ensure summa must be number or ensure summa must be in range [1000-100000]UAH";
                    return;
                }
                label_status.Text = "";

                Ensure_AgentClient claim = new Ensure_AgentClient();
                label_status.Text=claim.AddClaim(out cost,sum, monthCalendar_from.SelectionStart, monthCalendar_to.SelectionStart, comboBox_risk.SelectedIndex + 1, textBox_passport.Text);
                textBox_cost.Text = cost.ToString();
               
            }
            catch (Exception ee)
            {
                label_status.Text = ee.Message;
            }
        }
    }
}
