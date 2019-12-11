using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagok; Uid=root; Pwd=;");
            conn.Open();
            VarosListazas();
            this.Text= "LatvanyossagokApplication";
            
        }

        void VarosListazas()
        {
            Varosok_ListBox.Items.Clear();
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

                    Varosok_ListBox.Items.Add(varosok);
                }
            }
            comboBoxElemek();
        }

        private void Varos_Lakossag_Hozzaad_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(VarosHozzaad_textBox.Text) || String.IsNullOrWhiteSpace(LakossagHozzaad_numericUpDown.Text))
                {
                    MessageBox.Show("Minden mező legyen kitöltve!");
                    return;
                }
                else if (LakossagHozzaad_numericUpDown.Value < 0)
                {
                    MessageBox.Show("Nem lehet minuszban a lakosság!");
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO varosok (nev, lakossag) VALUES (@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", VarosHozzaad_textBox.Text);
                cmd.Parameters.AddWithValue("@lakossag", LakossagHozzaad_numericUpDown.Text);
                cmd.ExecuteNonQuery();
                VarosListazas();              
            }
            catch (MySqlException)
            {
                    MessageBox.Show("A Város már létezik, kérlek addj meg egy másikat!");              
            }
            
        }
        private void comboBoxElemek()
        {
            Latvanyossagok_comboBox.Items.Clear();
            foreach (var elemek in Varosok_ListBox.Items)
            {
                Latvanyossagok_comboBox.Items.Add(elemek);
            }
            
        }

        private void LatvanyossagokListazas(int varosID)
        {
            try
            {
                Latvanyossagok_ListBox.Items.Clear();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT l.id, l.nev, leiras, ar, varos_id
                                    FROM latvanyossagok l
                                    LEFT JOIN varosok v
                                    ON l.varos_id = v.id
                                    WHERE varos_id=@varos_id";

                cmd.Parameters.AddWithValue("@varos_id", varosID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var varos_id = reader.GetInt32("varos_id");
                        Latvanyossagok_ListBox.Items.Add(new Latvanyossagok(id, nev, leiras, ar, varos_id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Latvanyossagok_hozzaad_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Latvanyossagok_comboBox.Text) 
                    || String.IsNullOrWhiteSpace(Leiras_TextBox.Text) 
                    || String.IsNullOrWhiteSpace(LatvanyossagNeve_textBox.Text) )
                {
                    MessageBox.Show("Minden mező legyen kitöltve!");
                    return;
                }
                if (Latvanyossagok_comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva város!");
                    return;
                }
                if (Latvanyossagok_numericUpDown.Value<0)
                {
                    MessageBox.Show("Nem fognak fizetni neked! :D");
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO latvanyossagok (nev, leiras, ar, varos_id) VALUES (@nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", LatvanyossagNeve_textBox.Text);
                cmd.Parameters.AddWithValue("@leiras", Leiras_TextBox.Text);
                cmd.Parameters.AddWithValue("@ar", Latvanyossagok_numericUpDown.Text);
                cmd.Parameters.AddWithValue("@varos_id", ((Varosok)Latvanyossagok_comboBox.SelectedItem).Id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sikeres hozzáadás");

                LatvanyossagokListazas(((Varosok)Latvanyossagok_comboBox.SelectedItem).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Latvanyossagok_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LatvanyossagokListazas(((Varosok)Latvanyossagok_comboBox.SelectedItem).Id); // azért kell hogy betöltse a listboxba a kiválasztott cuccot, és a comboboxnak az eventjére kellet beállitani
        }

        private void Varosok_torles_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Varosok_ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki egy várost!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM varosok WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", ((Varosok)Varosok_ListBox.SelectedItem).Id);

                cmd.ExecuteNonQuery();
                VarosListazas();
            }
            catch (Exception ex)
            {              
                MessageBox.Show(ex.Message);
            }
        }

        private void latvanyossagok_torlesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Latvanyossagok_comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("válasszon ki várost");
                    return;
                }
                else if (Latvanyossagok_ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki látványosságot!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM latvanyossagok WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", ((Latvanyossagok)Latvanyossagok_ListBox.SelectedItem).Id);

                cmd.ExecuteNonQuery();
               LatvanyossagokListazas(((Varosok)Latvanyossagok_comboBox.SelectedItem).Id); //mert  avárosoknak a látványossága (ittis a comboboxban lévő város id)
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message);
            }
        }

        private void Latvanyossagok_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void varosok_modositasButton_Click(object sender, EventArgs e)
        {
                if (Varosok_ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva Város!");
                    return;
                }
            else
            {
                Form2 masodikForm = new Form2(Varosok_ListBox.Text, (((Varosok)Varosok_ListBox.SelectedItem).Id));
                masodikForm.ShowDialog();
                
            }                          
        }

        private void latvanyossagok_modositasButton_Click(object sender, EventArgs e)
        {
            Form3 harmadikForm = new Form3(Latvanyossagok_comboBox.Text, LatvanyossagNeve_textBox.Text, Leiras_TextBox.Text, Latvanyossagok_numericUpDown.Value);
            harmadikForm.ShowDialog();
        }

        //-MÓDOSíTÁS 
    }
}
