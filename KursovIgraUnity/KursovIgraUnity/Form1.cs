using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formA
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        private string sql = "SELECT * FROM Car";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["KursDB"].ConnectionString);
            sqlConnection.Open();

            adapter = new SqlDataAdapter(sql, sqlConnection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["Id"].ReadOnly = true;
            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Дядя мы танцуем в пятницу");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adapter.InsertCommand = new SqlCommand("sp_CreateCar", sqlConnection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.Text, 0, "Model"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Year", SqlDbType.Text, 0, "Year"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Fuel", SqlDbType.Text, 0, "Fuel"));

            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            adapter.Update(ds);
        }
    }
}
