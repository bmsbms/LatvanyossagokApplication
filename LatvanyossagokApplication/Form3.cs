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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        public Form3(String kivalasztottVaros,string latvanyossagNev,string leiras,int ar)
        {
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagok; Uid=root; Pwd=;");
            conn.Open();
            InitializeComponent();
            kivalasztottVarosUpdate_textBox.Text = kivalasztottVaros;
            LatvanyossagNevUpdate_textBox.Text = latvanyossagNev;
            LatvanyossagLeirasUpdate_textbox.Text = leiras;
            LatvanyossagArUpdate_numericUpDown.Value = ar;
           
        }

        private void form3_modositasButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(LatvanyossagNevUpdate_textBox.Text) || String.IsNullOrWhiteSpace(LatvanyossagLeirasUpdate_textbox.Text))
                {
                    MessageBox.Show("Minden legyen kitöltve!");
                    return;
                }
                else if (LatvanyossagArUpdate_numericUpDown.Value < 0)
                {
                    MessageBox.Show("nem lehet 0-nál kisebb");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE latvanyossagok 
                                    SET nev = @nev, 
                                        leiras = @leiras
                                        ar=@ar
                                    WHERE id = @id";
                cmd.Parameters.AddWithValue("@nev", LatvanyossagNevUpdate_textBox.Text);
                cmd.Parameters.AddWithValue("@leiras", LatvanyossagLeirasUpdate_textbox.Text);
                cmd.Parameters.AddWithValue("@ar", LatvanyossagArUpdate_numericUpDown.Value);
                //  cmd.Parameters.AddWithValue("@id", id); nemtom

                cmd.ExecuteNonQuery();
             //   VarosListazas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
