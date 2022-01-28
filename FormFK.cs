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
    public partial class FormFK : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CSSkola"].ToString();
        DataTable ucenik = new DataTable();
        DataTable predmet = new DataTable();
        DataTable ocena = new DataTable();
        int broj = 0;
        public FormFK()
        {
            InitializeComponent();
        }

        private void FormFK_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime as naziv FROM ucenik ORDER BY naziv", veza);
            adapter.Fill(ucenik);
            adapter = new SqlDataAdapter("SELECT * FROM predmet", veza);
            adapter.Fill(predmet);
            adapter = new SqlDataAdapter("SELECT * FROM ocena_ok", veza);
            adapter.Fill(ocena);
            comboBox1.DataSource = ucenik;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
            // comboBox1.SelectedIndex = -1;
            comboBox1.SelectedValue = ocena.Rows[broj]["ucenik_id"];
            
            comboBox2.DataSource = predmet;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "naziv";
            comboBox2.SelectedValue = ocena.Rows[broj]["predmet_id"];

            textBox1.Text = ocena.Rows[broj]["ocena"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj++;
            comboBox1.SelectedValue = ocena.Rows[broj]["ucenik_id"];
            comboBox2.SelectedValue = ocena.Rows[broj]["predmet_id"];
            textBox1.Text = ocena.Rows[broj]["ocena"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj--;
            comboBox1.SelectedValue = ocena.Rows[broj]["ucenik_id"];
            comboBox2.SelectedValue = ocena.Rows[broj]["predmet_id"];
            textBox1.Text = ocena.Rows[broj]["ocena"].ToString();

        }
    }
}
