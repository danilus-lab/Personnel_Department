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
    public partial class Staff_list : Form
    {
        public Staff_list()
        {
            InitializeComponent();

            sqlConnection1.Open();
            var temp_staff_list = new DataTable();

            temp_staff_list.Load(fill_the_tabel_command.ExecuteReader());

            staff_list_grid.DataSource = temp_staff_list;

            sqlConnection1.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (staff_list_grid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staff_list_grid.SelectedRows[0];

                string id_record = selectedRow.Cells["Номер записи"].Value.ToString();
                string num_dep = selectedRow.Cells["Номер отдела"].Value.ToString();
                string post_name = selectedRow.Cells["Должность"].Value.ToString();
                string count_units = selectedRow.Cells["Количество рабочих мест"].Value.ToString();
                string salary = selectedRow.Cells["Зарплата"].Value.ToString();

                Form frm = new Change_row_in_staff_list(id_record, num_dep, post_name, count_units, salary);
                frm.Show();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp_staff_list = new DataTable();

            temp_staff_list.Load(fill_the_tabel_command.ExecuteReader());

            staff_list_grid.DataSource = temp_staff_list;

            sqlConnection1.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form frm = new Add_row_in_staff_list();
            frm.Show();
        }

        private void delete_row_Click(object sender, EventArgs e)
        {
            if (staff_list_grid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staff_list_grid.SelectedRows[0];

                sqlConnection1.Open();

                deleteCommand.Parameters["@id_record"].Value = Convert.ToInt32(selectedRow.Cells["Номер записи"].Value);

                deleteCommand.ExecuteNonQuery();

                sqlConnection1.Close();

                string result = Convert.ToString(deleteCommand.Parameters["@message"].Value);
                MessageBox.Show(result);

                sqlConnection1.Open();
                var temp_staff_list = new DataTable();

                temp_staff_list.Load(fill_the_tabel_command.ExecuteReader());

                staff_list_grid.DataSource = temp_staff_list;

                sqlConnection1.Close();
            }
        }
    }
}
