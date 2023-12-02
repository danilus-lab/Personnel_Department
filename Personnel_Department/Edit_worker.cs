using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Edit_worker : Form
    {
        public Edit_worker(string num_worker, string phone, string fio, string num_dep, string post_name, string allowance)
        {
            InitializeComponent();

            trick.Text = num_worker;
            fio_textBox.Text = fio;
            dep_textBox.Text = num_dep;
            phone_number.Text = phone;
            post_name_textBox.Text = post_name;

            dep_comboBox.Text = num_dep;
            post_name_combo.Text = post_name;

            allowance_textBox.Text = allowance;

        }

        private void save_changes_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            change_worker_Command.Parameters["@id_worker"].Value = Convert.ToInt32(trick.Text);
            change_worker_Command.Parameters["@fio"].Value = fio_textBox.Text.ToString();
            change_worker_Command.Parameters["@num_dep"].Value = Convert.ToInt32(dep_comboBox.SelectedValue);
            change_worker_Command.Parameters["@post_name"].Value = post_name_combo.SelectedValue.ToString();
            change_worker_Command.Parameters["@phone"].Value = phone_number.Text.ToString();
            change_worker_Command.Parameters["@allowance"].Value = Convert.ToSingle(allowance_textBox.Text);

            check_phone_comm.Parameters["@id_worker"].Value = Convert.ToInt32(trick.Text);
            check_phone_comm.Parameters["@phone"].Value = phone_number.Text;

            check_phone_comm.ExecuteNonQuery();

            string result = Convert.ToString(check_phone_comm.Parameters["@message"].Value);

            if (result == "можно")
            {

                change_worker_Command.ExecuteNonQuery();
                sqlConnection1.Close();
                result = Convert.ToString(change_worker_Command.Parameters["@message"].Value);
                MessageBox.Show(result);
            }
            else
            {
                sqlConnection1.Close();
                MessageBox.Show(
                "Номер телефона не уникален!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void dep_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Post_name from [dbo].[StaffList] WHERE Num_dep = @dep and Vacant > 0";
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection1))
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

        private void Edit_worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Dep". При необходимости она может быть перемещена или удалена.
            this.depTableAdapter.Fill(this.otdel_kadrovDataSet.Dep);

        }
    }
}
