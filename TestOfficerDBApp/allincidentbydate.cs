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
    public partial class allincidentbydate : Form
    {
        string cs = "Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public allincidentbydate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void offendersBindingSource7_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void officerDBDataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void allincidentbydate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select offenders.LastName [Offender LastName], offenders.FirstName as [Offender FirstName], incidents.incidentDetails as [Incident Details], offenders.Notes as [Notes on Offender], incidents.incidentDate as [Date of Incident], officers.LastName as [Officer LastName] from incidents inner join offenders on incidents.offenderID = offenders.offenderid inner join officers on incidents.officerID = officers.officerID", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select offenders.LastName [Offender LastName], offenders.FirstName as [Offender FirstName], incidents.incidentDetails as [Incident Details], offenders.Notes as [Notes on Offender], incidents.incidentDate as [Date of Incident], officers.LastName as [Officer LastName] from incidents inner join offenders on incidents.offenderID = offenders.offenderid inner join officers on incidents.officerID = officers.officerID where incidentDate = '" + dateTimePicker1.Value + "'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
