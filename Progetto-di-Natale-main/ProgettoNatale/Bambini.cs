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

namespace ProgettoNatale
{
    public partial class Bambini : Form
    {
        SqlConnection connection;
        public Bambini(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        internal void Visualizza(string QuerySql)
        {
            SqlCommand cmd = new SqlCommand(QuerySql, connection);
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataGridView1.DataSource = dt;

            dataReader.Close();
        }

        private void Bambini_Load(object sender, EventArgs e)
        {
            Visualizza("SELECT * FROM Bambini");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
