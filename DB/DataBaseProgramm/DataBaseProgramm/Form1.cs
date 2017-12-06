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
    public partial class Form1 : Form
    {
        string key_for_execute_query = "all";
        string DB = "";
        public Form1()
        {
            InitializeComponent();
#if MSSQL
            DB = "Data Source=MAX;Initial Catalog=\"categories of vehicles\";Integrated Security=True";
#elif MYSQL
            DB = "server=10.0.41.165; port=3306; database=categories_of_vehicles; user=root; password=123456; CharSet=utf8;";
#endif
            pictureBox1.Image = Image.FromFile(@"E:\2_2\DB\DataBaseProgramm\im.png");
            Check_existing();

        }

        internal void Check_existing()
        {
#if MSSQL
            using (SqlConnection conn = new SqlConnection(DB))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("select categorie from categorie_t", conn);
                SqlDataReader reader = comm.ExecuteReader();

#elif MYSQL
            using (MySqlConnection conn = new MySqlConnection(DB))
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("select categorie from categorie_t", conn);
                MySqlDataReader reader = comm.ExecuteReader();
#endif
                if (!reader.HasRows)
                {
                    Change_data(@"insert
                                        into categorie_t (categorie, descripe)
                                        values ('Q',N'Це дуже цікава категорія');");
                    Change_data(@"insert
                                        into categorie_t (categorie, descripe)
                                        values ('W',N'Це дуже небезпечна категорія');");
                    reader.Close();
                    reader = comm.ExecuteReader();
                }

                categories.Items.Clear();
                while (reader.Read())
                    categories.Items.Add(reader[0]);
                reader.Close();
#if MSSQL
                comm = new SqlCommand("select id_representative from representative_t;", conn);
#elif MYSQL
                comm = new MySqlCommand("select id_representative from representative_t;", conn);
#endif
                reader = comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    Change_data(@"insert 
                                        into representative_t (representative, id_categorie)
	                                    values ('Juju','"+categories.Items[0].ToString()+"');");
                    Change_data(@"insert 
                                        into representative_t (representative, id_categorie)
	                                    values ('Lilu','" + categories.Items[1].ToString() + "');");
                }
            }
        }
        /// <summary>
        /// Get transport click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void get_repr_Click(object sender, EventArgs e)
        {
            groupBox_3way.Enabled = true;
            radioButton_get_all.Checked = true;
            key_for_execute_query = "all";
            button_query.Enabled = true;
        }

        private void by_categorie_CheckedChanged(object sender, EventArgs e)
        {
            categories.Enabled = true;
            key_for_execute_query = "cat";
        }

        private void delete_mark_from_repre(object sender, EventArgs e)
        {
            categories.Enabled = false;
        }

        private void by_id_Click(object sender, EventArgs e)
        {
            textBox_id.Enabled = true;
            key_for_execute_query = "id";
        }
        private void radioButton_get_all_Click(object sender, EventArgs e)
        {
            key_for_execute_query = "all";
        }

        private void by_id_CheckedChanged(object sender, EventArgs e)
        {
            textBox_id.Enabled = false;
        }
        /// <summary>
        /// Clen up mark from get transport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_mark_from_get(object sender, EventArgs e)
        {
            groupBox_3way.Enabled = false;
            categories.Enabled = false;
            textBox_id.Enabled = false;
        }

        private void add_transports_Click(object sender, EventArgs e)
        {
            textBox_repr.Enabled = true;
            categories.Enabled = true;
            textBox_repr.Focus();
            key_for_execute_query = "add";
        }

        private void add_transports_CheckedChanged(object sender, EventArgs e)
        {
            textBox_repr.Enabled = false;
            categories.Enabled = false;
        }

        private void update_tra_Click(object sender, EventArgs e)
        {
            textBox_id.Enabled = true;
            textBox_repr.Enabled = true;
            categories.Enabled = true;
            textBox_id.Focus();
            button_query.Enabled = true;
            key_for_execute_query = "upd";
        }

        private void update_tra_CheckedChanged(object sender, EventArgs e)
        {
            textBox_id.Enabled = false;
            textBox_repr.Enabled = false;
            categories.Enabled = false;
        }

        private void delete_tra_Click(object sender, EventArgs e)
        {
            textBox_id.Enabled = true;
            button_query.Enabled = true;
            key_for_execute_query = "del";
        }

        private void delete_tra_CheckedChanged(object sender, EventArgs e)
        {
            textBox_id.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            by_categorie.Enabled = false;
            by_id.Enabled = false;
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

                switch (arr.Length)
                {
                    case 2:
                        while (reader.Read())
                            dgt.Rows.Add(reader[0], reader[1]);
                        break;
                    case 4:
                        while (reader.Read())
                            dgt.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                        break;
                }
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
                case "cat":
                    if (categories.SelectedItem as String == null)
                        categories.SelectedItem = categories.Items[0];

                    Add_data(new string[] { "ID","Representative", "Categorie", "Descripe" },
                        @"select id_representative,representative, categorie, descripe 
                                    from representative_t as r left outer join categorie_t as c
                                        on r.id_categorie = c.categorie
                                            where categorie = '" + categories.SelectedItem.ToString() + "';");
                    break;

                case "id":
                    if (!(new Regex("^[1-9][0-9]*$")).IsMatch(textBox_id.Text))
                    {
                        textBox_message.Text = "It's not number, please, enter integer";
                        textBox_message.Visible = true;
                        break;
                    }
                    Add_data(new string[] { "id", "representative" },
                                            @"select id_representative, representative
                                                    from representative_t
                                                        where id_representative =" + textBox_id.Text + ";");
                    break;

                case "all":
                    Add_data(new string[] { "id", "representative", "categorie", "descripe" },
                                             @"select  id_representative, representative, categorie, descripe 
                                                    from representative_t as r inner join categorie_t as c
                                                        on r.id_categorie = c.categorie; ");
                    break;

                case "add":
                    if (!(new Regex("^[а-яА-Яa-zA-Z]{3,32}$")).IsMatch(textBox_repr.Text))
                    {
                        textBox_message.Text = "Name of representative can't contain number and lenght must be in range [3,32]";
                        textBox_message.Visible = true;
                        break;
                    }
                    if (categories.SelectedItem as String == null)
                        categories.SelectedItem = categories.Items[0];
                    Change_data(@"insert 
                                        into representative_t (representative, id_categorie)
	                                    values (N'" + textBox_repr.Text + "','" + categories.SelectedItem.ToString() + "');");
                    break;

                case "upd":

                    if (!(new Regex("^[а-яА-Яa-zA-Z]{3,32}$")).IsMatch(textBox_repr.Text) || !(new Regex("^[1-9][0-9]*$")).IsMatch(textBox_id.Text))
                    {
                        textBox_message.Text = "Name of representative can't contain number and lenght must be in range [1,3] or ID's not integer";
                        textBox_message.Visible = true;
                        break;
                    }
                    if (categories.SelectedItem as String == null)
                        categories.SelectedItem = categories.Items[0];
                    Change_data(@"update representative_t
                                set representative=N'" + textBox_repr.Text + "', id_categorie='" + categories.SelectedItem.ToString() +  @"'
                                where id_representative=" + textBox_id.Text + ";");
                    break;

                case "del":
                    if (!(new Regex("^[1-9][0-9]*$")).IsMatch(textBox_id.Text))
                    {
                        textBox_message.Text = "It's not number, please, enter integer";
                        textBox_message.Visible = true;
                        break;
                    }
                    Change_data(@"delete from representative_t 
	                            where id_representative=" + textBox_id.Text + ";");
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox_message.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox_message.Visible = false;
        }

        private void radioButton_get_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
