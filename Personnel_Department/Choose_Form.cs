using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Choose_Form : Form
    {
        public Choose_Form()
        {
            InitializeComponent();

            sqlConnection1.Open();
            check_status.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void add_worker_Click(object sender, EventArgs e)
        {
            Form frm = new Add_Worker_Form();
            frm.Show();
        }

        private void all_workers_Click(object sender, EventArgs e)
        {
            Form frm = new List_Of_Workers();
            frm.Show();
        }

        private void delete_worker_Click(object sender, EventArgs e)
        {
            Form frm = new Delete_worker();
            frm.Show();
        }

        private void new_vacation_Click(object sender, EventArgs e)
        {
            Form frm = new Create_vacation();
            frm.Show();
        }

        private void new_medical_Click(object sender, EventArgs e)
        {
            Form frm = new Create_medical();
            frm.Show();
        }

        private void new_trip_Click(object sender, EventArgs e)
        {
            Form frm = new Create_mission();
            frm.Show();
        }

        private void staff_list_Click(object sender, EventArgs e)
        {
            Form frm = new Staff_list();
            frm.Show();
        }

        private void vacations_Click(object sender, EventArgs e)
        {
            Form frm = new Vacations_list();
            frm.Show();
        }

        private void medicals_Click(object sender, EventArgs e)
        {
            Form frm = new Medicals_list();
            frm.Show();
        }

        private void missions_Click(object sender, EventArgs e)
        {
            Form frm = new Missions_list();
            frm.Show();
        }

        private void dep_Click(object sender, EventArgs e)
        {
            Form frm = new Deps_list();
            frm.Show();
        }
    }
}
