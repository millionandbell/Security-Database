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

namespace TestOfficerDBApp
{
    public partial class AllActiveOfficersForm : Form
        {

        string cs = "Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public AllActiveOfficersForm()
        {
            InitializeComponent();
        }

        private void AllActiveOfficersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officerDBDataSet.officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.officerDBDataSet.officers);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.officersTableAdapter.Fill(this.officerDBDataSet.officers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select FirstName, LastName from officers where FirstName like '" + textBox1.Text + "%'" + "or Lastname like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
