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
    public partial class Edit_vacation : Form
    {
        public Edit_vacation(string num_vac, string start, string end)
        {
            InitializeComponent();
            trick.Text = num_vac;
            dateTimePicker1.Value = DateTime.Parse(start);
            dateTimePicker2.Value = DateTime.Parse(end);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                sqlConnection1.Open();

                save_changes_comm.Parameters["@id"].Value = Convert.ToInt32(trick.Text);
                save_changes_comm.Parameters["@date_start"].Value = dateTimePicker1.Value;
                save_changes_comm.Parameters["@date_end"].Value = dateTimePicker2.Value;

                save_changes_comm.ExecuteNonQuery();
                sqlConnection1.Close();

                string result = Convert.ToString(save_changes_comm.Parameters["@message"].Value);
                MessageBox.Show(result);



            }
            else
            {
                MessageBox.Show(
                "Дата начала должна быть раньше даты окончания!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }
    }
}
