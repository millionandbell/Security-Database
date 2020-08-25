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
    public partial class incidentForm : Form
    {

        // create connection
        string cs = "Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        SqlCommand cmd;


        public incidentForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officerDBDataSet1.officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.officerDBDataSet1.officers);

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select offenderid as [Offender ID], FirstName, LastName, Operatorslicense, dob from offenders", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.offendersTableAdapter.Fill(this.officerDBDataSet11.offenders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select offenderid as [Offender ID], FirstName, LastName, Operatorslicense, dob from offenders where FirstName like '" + offendertext.Text + "%'" + "or Lastname like '" + offendertext.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            offendernamebox.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString()
            + " " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            offenderidbox.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (officernamebox.Text != "")
            {
                cmd = new SqlCommand("insert into incidents (officerid, offenderid, incidentdetails) VALUES (@officerid, @offenderid, @incidentdetails) ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@officerid", officernamebox.SelectedValue.ToString()); // add officer id textbox
                cmd.Parameters.AddWithValue("@offenderid", offenderidbox.Text);
                cmd.Parameters.AddWithValue("@incidentdetails", richTextBox1.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully added offender.");
               // DisplayData();
               // ClearData();
            }
            else
            {
                MessageBox.Show("Unsuccessfully added Offender. Did you fill all data?");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void offenderidbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
