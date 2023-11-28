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
    public partial class Edit_worker : Form
    {
        public Edit_worker(string num_worker, string fio, string num_dep, string post_name, string allowance)
        {
            InitializeComponent();

            trick.Text = num_worker;
            fio_textBox.Text = fio;
            dep_textBox.Text = num_dep;
            post_name_textBox.Text = post_name;
            allowance_textBox.Text = allowance;

        }

        private void save_changes_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            change_worker_Command.Parameters["@id_worker"].Value = Convert.ToInt32(trick.Text);
            change_worker_Command.Parameters["@fio"].Value = fio_textBox.Text.ToString();
            change_worker_Command.Parameters["@num_dep"].Value = Convert.ToInt32(dep_textBox.Text);
            change_worker_Command.Parameters["@post_name"].Value = post_name_textBox.Text.ToString();
            change_worker_Command.Parameters["@allowance"].Value = Convert.ToSingle(allowance_textBox.Text);

            change_worker_Command.ExecuteNonQuery();

            sqlConnection1.Close();

            string result = Convert.ToString(change_worker_Command.Parameters["@message"].Value);
            MessageBox.Show(result);
        }
    }
}
