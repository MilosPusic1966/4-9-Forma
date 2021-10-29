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

namespace _4_9_Forma
{
    public partial class Form1 : Form
    {
        public int red = 0;
        DataTable ucenik = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Osvezi()
        {
            if (ucenik.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_ocena.Text = "";
                btn_next.Enabled = false;
                btn_prev.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                txt_id.Text = ucenik.Rows[red]["id"].ToString();
                txt_ime.Text = ucenik.Rows[red]["ime"].ToString();
                txt_prezime.Text = ucenik.Rows[red]["prezime"].ToString();
                txt_ocena.Text = ucenik.Rows[red]["ocena"].ToString();
                if (red == ucenik.Rows.Count - 1)
                {
                    btn_next.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    btn_next.Enabled = true;
                    button1.Enabled = true;
                }
                //btn_next.Enabled = (red != ucenik.Rows.Count - 1);
                btn_prev.Enabled = (red != 0);
                button2.Enabled = (red != 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string CS = "Data source=INF_4_PROFESOR\\SQLPBG; Initial catalog=MilosP2021; Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime, prezime, ocena FROM ucenik", veza);
            adapter.Fill(ucenik);
            // MessageBox.Show(ucenik.Rows.Count.ToString());
            Osvezi();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            red++;
            Osvezi();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            red--;
            Osvezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            red = ucenik.Rows.Count - 1;
            Osvezi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            red = 0;
            Osvezi();
        }
    }
}
