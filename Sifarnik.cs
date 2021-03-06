using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _4_9_Forma
{
    public partial class Sifarnik : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CSSkola"].ConnectionString;
        SqlDataAdapter adapter;
        DataTable podaci;
        string tabela;
        public Sifarnik(string naziv)
        {
            InitializeComponent();
            tabela = naziv;
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            adapter = new SqlDataAdapter("SELECT * FROM " + tabela, veza); ;
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            // dataGridView1.Columns["id"].ReadOnly = true;
            // dataGridView1.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            // dataGridView2.DataSource = menjano;
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
