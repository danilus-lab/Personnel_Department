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
    public partial class Vacations_list : Form
    {
        public Vacations_list()
        {
            InitializeComponent();

            sqlConnection1.Open();
            var temp = new DataTable();

            temp.Load(fill_the_table_comm.ExecuteReader());

            dataGridView1.DataSource = temp;

            sqlConnection1.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id_record = selectedRow.Cells["Номер отпуска"].Value.ToString();
                string date_start = selectedRow.Cells["Дата начала"].Value.ToString();
                string date_end = selectedRow.Cells["Дата окончания"].Value.ToString();

                Form frm = new Edit_vacation(id_record, date_start, date_end);
                frm.Show();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp_staff_list = new DataTable();

            temp_staff_list.Load(fill_the_table_comm.ExecuteReader());

            dataGridView1.DataSource = temp_staff_list;

            sqlConnection1.Close();
        }
    }
}
