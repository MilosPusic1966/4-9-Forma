using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _4_9_Forma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string CS = ConfigurationManager.ConnectionStrings["CSSkola"].ToString();
            SqlConnection veza = new SqlConnection(CS);
            DataTable korisnici = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM korisnik WHERE email='" + user + "'", veza);
            ad.Fill(korisnici);
            if (korisnici.Rows.Count == 1)
            {
                if (String.Compare(korisnici.Rows[0]["pass"].ToString(), pass) == 0)
                {
                    this.Hide();
                    Glavna forma = new Glavna();
                    forma.Show();                    
                }
                else MessageBox.Show("Nije dobra lozinka");
            }
            else MessageBox.Show("Nije dobar email");
            
        }
    }
}
