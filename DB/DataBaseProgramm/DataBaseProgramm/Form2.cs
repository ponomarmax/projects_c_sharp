#define MSSQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseProgramm
{
    public partial class Form2 : Form
    {
        string key_for_execute_query = "";
        string DB = "";
        Form1 form;
        public Form2()
        {
            InitializeComponent();

#if MSSQL
            DB = "Data Source=MAX;Initial Catalog=\"categories of vehicles\";Integrated Security=True";
#elif MYSQL
            DB = "server=10.0.41.165; port=3306; database=categories_of_vehicles; user=root; password=123456; CharSet=utf8;";
#endif
            pictureBox1.Image = Image.FromFile(@"E:\DB\DataBaseProgramm\im.png");
        }
        public Form2(Form1 form) : this()
        {
            this.form = form;
        }

        private void radioButton_add_categorie_Click(object sender, EventArgs e)
        {
            textBox_f2_categorie.Enabled = true;
            textBox_f2_descripe.Enabled = true;
            key_for_execute_query = "add";
        }

        private void radioButton_add_categorie_CheckedChanged(object sender, EventArgs e)
        {
            textBox_f2_categorie.Enabled = false;
            textBox_f2_descripe.Enabled = false;
        }

        private void radioButton_update_categorie_Click(object sender, EventArgs e)
        {
            textBox_f2_id.Enabled = true;
            textBox_f2_categorie.Enabled = true;
            textBox_f2_descripe.Enabled = true;
            key_for_execute_query = "upd";
        }

        private void radioButton_update_categorie_CheckedChanged(object sender, EventArgs e)
        {
            textBox_f2_id.Enabled = false;
            textBox_f2_categorie.Enabled = false;
            textBox_f2_descripe.Enabled = false;
        }

        private void radioButton_delete_categorie_Click(object sender, EventArgs e)
        {
            textBox_f2_id.Enabled = true;
            key_for_execute_query = "del";
        }

        private void radioButton_delete_categorie_CheckedChanged(object sender, EventArgs e)
        {
            textBox_f2_id.Enabled = false;
        }
        private void Add_data(string[] arr, string query)
        {
#if MSSQL
            using (SqlConnection con = new SqlConnection(DB))
            {
                SqlCommand comm;
                SqlDataReader reader;
                con.Open();
                comm = new SqlCommand(query, con);
#elif MYSQL
            using (MySqlConnection con = new MySqlConnection(DB))
            {
                MySqlCommand comm;
                MySqlDataReader reader;
                con.Open();
                comm = new MySqlCommand(query, con);
#endif


                reader = comm.ExecuteReader();
                dgt.Columns.Clear();
                dgt.Rows.Clear();
                for (int i = 0; i < arr.Length; ++i)
                {
                    dgt.Columns.Add("", arr[i]);
                    dgt.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                while (reader.Read())
                    dgt.Rows.Add(reader[0], reader[1], reader[2]);
            }
        }
        private void Change_data(string query)
        {

            int a;
#if MSSQL
            using (SqlConnection con = new SqlConnection(DB))
            {
                SqlCommand comm;
                con.Open();
                comm = new SqlCommand(query, con);
#elif MYSQL
            using (MySqlConnection con = new MySqlConnection(DB))
            {
                MySqlCommand comm;
                con.Open();
                comm = new MySqlCommand(query, con);
#endif

                a = comm.ExecuteNonQuery();
                textBox_message.Text = a + " affected" + "\r\n";
                textBox_message.Visible = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_message.Visible = false;
            switch (key_for_execute_query)
            {
                case "all":
                    Add_data(new string[] { "id", "categorie", "descripe" },
                                             @"select id_categorie, categorie, descripe 
                                                from categorie_t; ");
                    break;

                case "add":
                    if (!(new Regex("^[а-яА-Яa-zA-Z0-9]{1,3}$")).IsMatch(textBox_f2_categorie.Text))
                    {
                        textBox_message.Text = "Name of categorie can't contain number and lenght must be in range [3,32]";
                        textBox_message.Visible = true;
                        break;
                    }

                    Change_data(@"insert 
                                into categorie_t (categorie, descripe)
	                            values (N'" + textBox_f2_categorie.Text + "', N'" + textBox_f2_descripe.Text.ToString() + "');");
                    break;

                case "upd":

                    if (!(new Regex("^[а-яА-Яa-zA-Z0-9]{1,3}$")).IsMatch(textBox_f2_categorie.Text) || !(new Regex("^[1-9][0-9]*$")).IsMatch(textBox_f2_id.Text))
                    {
                        textBox_message.Text = "Name of representative can't contain number and lenght must be in range [3,32] or ID's not integer";
                        textBox_message.Visible = true;
                        break;
                    }
#if MSSQL
                    using (SqlConnection con = new SqlConnection(DB))
                    {
                        SqlCommand comm;
                        SqlDataReader reader;
                        con.Open();
                        comm = new SqlCommand("select id_categorie from categorie_t;", con);
#elif MYSQL
                    using (MySqlConnection con = new MySqlConnection(DB))
                    {
                        MySqlCommand comm;
                        MySqlDataReader reader;
                        con.Open();
                        comm = new MySqlCommand("select id_categorie from categorie_t;", con);
#endif

                        reader = comm.ExecuteReader();
                        bool flag = false;
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == textBox_f2_id.Text)
                                flag = true;
                        }
                        if (!flag)
                        {
                            textBox_message.Text = "This id is not exist";
                            textBox_message.Visible = true;
                            break;
                        }
                    }
                    Change_data(@"update categorie_t
                                set categorie=N'" + textBox_f2_categorie.Text + "', descripe=N'" + textBox_f2_descripe.Text + @"'
                                where id_categorie=" + textBox_f2_id.Text + ";");
                    break;

                case "del":
                    if (!(new Regex("^[1-9][0-9]*$")).IsMatch(textBox_f2_id.Text))
                    {
                        textBox_message.Text = "It's not number, please, enter integer";
                        textBox_message.Visible = true;
                        break;
                    }
                    Change_data(@"delete from categorie_t 
	                                 where id_categorie=" + textBox_f2_id.Text + ";");
                    break;
            }
        }

        private void radioButton_get_all_categories_Click(object sender, EventArgs e)
        {
            key_for_execute_query = "all";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Check_existing();
            form.Show();
            this.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            textBox_message.Visible = false;
        }
   
        private void label5_Click(object sender, EventArgs e)
        {
            textBox_message.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
