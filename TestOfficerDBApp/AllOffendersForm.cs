using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace TestOfficerDBApp
{
    public partial class AllOffendersForm : Form
    {
        string cs = "Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public AllOffendersForm()
        {
            InitializeComponent();
        }

        private void AllOffendersForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select FirstName, LastName, Operatorslicense, dob, Notes, photo from offenders", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_searchname_TextChanged_1(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select FirstName, LastName, Operatorslicense, dob, Notes, photo from offenders where FirstName like '" + txt_searchname.Text + "%'"  + "or Lastname like '" + txt_searchname.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) 
            {
                MessageBox.Show("Success? but really?");
            }
        }

        private void offendersBindingSource7_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void officerDBDataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    } 
}

