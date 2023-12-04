using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Deps_list : Form
    {
        public Deps_list()
        {
            InitializeComponent();

            myConnection.Open();
            var temp = new DataTable();

            temp.Load(fill_the_table.ExecuteReader());

            dataGridView1.DataSource = temp;

            myConnection.Close();

        }

        private void change_boss_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string dep = selectedRow.Cells["Номер отдела"].Value.ToString();

                Form frm = new Change_dep_boss(dep);
                frm.Show();

            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            var temp = new DataTable();

            temp.Load(fill_the_table.ExecuteReader());

            dataGridView1.DataSource = temp;

            myConnection.Close();
        }

        private void add_new_dep_button_Click(object sender, EventArgs e)
        {
            Form frm = new Add_new_dep();
            frm.Show();
        }
    }
}
