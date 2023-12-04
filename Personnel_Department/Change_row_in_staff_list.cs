using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Personnel_Department
{
    public partial class Change_row_in_staff_list : Form
    {
        public Change_row_in_staff_list(string id_record, string num_dep, string post_name, string count_units, string salary)
        {
            InitializeComponent();

            trick.Text = id_record;
            vacant_units_textBox.Text = count_units;
            salary_textBox.Text = salary;
        }

        private void save_chenges_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            save_row_command.Parameters["@id_record"].Value = Convert.ToInt32(trick.Text);
            save_row_command.Parameters["@vacant_units"].Value = Convert.ToInt32(vacant_units_textBox.Text);
            save_row_command.Parameters["@salary"].Value = Convert.ToSingle(salary_textBox.Text);

            save_row_command.ExecuteNonQuery();

            sqlConnection1.Close();

            string result = Convert.ToString(save_row_command.Parameters["@message"].Value);
            MessageBox.Show(result);
        }

        private void salary_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверка наличия только одной запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void num_dep_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void count_units_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void post_name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 'Ё' && e.KeyChar != 'ё')
            {
                e.Handled = true;
            }
        }
    }
}
