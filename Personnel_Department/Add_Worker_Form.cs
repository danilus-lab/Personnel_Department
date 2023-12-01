using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Add_Worker_Form : Form
    {
        public Add_Worker_Form()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sex_comboBox.SelectedIndex = 1;
            addCommand.Parameters["@Fio"].Value = fio_textBox.Text;
            addCommand.Parameters["@Dep"].Value = dep_comboBox.SelectedValue;
            addCommand.Parameters["@Date_receprion"].Value = dateTimePicker.Value;
            addCommand.Parameters["@Post_name"].Value = post_name_combo.SelectedValue;
            addCommand.Parameters["@Data_birth"].Value = birth_date.Value;
            addCommand.Parameters["@Sex"].Value = sex_comboBox.SelectedItem.ToString();
            addCommand.Parameters["@Stage"].Value = stage_textbox.Text;

            if (fio_textBox.Text != "" && dep_comboBox.SelectedValue != "" && dateTimePicker.Text != "" && post_name_combo.SelectedValue != "" && stage_textbox.Text != "")
            {
                myConnection.Open();
                addCommand.ExecuteNonQuery();
                myConnection.Close();

                MessageBox.Show(
                "Работник успешно добавлен",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                MessageBox.Show(
                "Заполните обязательные поля!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void stage_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dep_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void fio_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back || char.IsUpper(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void postname_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 'Ё' && e.KeyChar != 'ё' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Add_Worker_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.StaffList". При необходимости она может быть перемещена или удалена.
            this.staffListTableAdapter.Fill(this.otdel_kadrovDataSet.StaffList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Dep". При необходимости она может быть перемещена или удалена.
            this.depTableAdapter.Fill(this.otdel_kadrovDataSet.Dep);

        }

        private void dep_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Post_name from [dbo].[StaffList] WHERE Num_dep = @dep and Vacant > 0";
            using (SqlCommand cmd = new SqlCommand(sql, myConnection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.Parameters.AddWithValue("@dep", Convert.ToInt32(dep_comboBox.SelectedValue));
                adapter.Fill(table);
                post_name_combo.DisplayMember = "Post_name";
                post_name_combo.ValueMember = "Post_name";
                post_name_combo.DataSource = table;
            }
        }
    }
}
