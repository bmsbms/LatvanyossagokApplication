using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form2(string Str_Value,int id)
        {
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagok; Uid=root; Pwd=;");
            conn.Open();
            string[] szeletel1 = Str_Value.Split('-');
            string[] szeletelt2 = Str_Value.Split(' ');

            string varosnev = szeletel1[0];
            int lakossag = Convert.ToInt32(szeletelt2[1]);

            InitializeComponent();
            varosUpdate_textBox.Text = varosnev;
            lakossagUpdate_numericUpDown.Value = lakossag;

        }
        public void VarosListazas()
        {
            
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, lakossag FROM varosok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varosok = new Varosok(id, nev, lakossag);

                   
                }
            }
            
        }
        private void modositas_button_form2_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(varosUpdate_textBox.Text))
                {
                    MessageBox.Show("Minden legyen kitöltve!");
                    return;
                }
                else if (lakossagUpdate_numericUpDown.Value <0)
                {
                    MessageBox.Show("0-nál több lakosnak kell lennie!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE varosok 
                                    SET nev = @nev, lakossag = @lakossag
                                    WHERE id = @id";
                cmd.Parameters.AddWithValue("@nev", varosUpdate_textBox.Text);
                cmd.Parameters.AddWithValue("@lakossag", lakossagUpdate_numericUpDown.Value);
              //  cmd.Parameters.AddWithValue("@id", id); nemtom

                cmd.ExecuteNonQuery();
                VarosListazas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vissza_Button_f2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
