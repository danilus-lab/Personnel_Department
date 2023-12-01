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
    public partial class Edit_mission : Form
    {
        public Edit_mission(string id, string place, string start, string end)
        {
            InitializeComponent();
            trick.Text = id;
            dateTimePicker1.Value = DateTime.Parse(start);
            dateTimePicker2.Value = DateTime.Parse(end);
            textBox1.Text = place;
        }

        private void save_changes_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                sqlConnection1.Open();

                save_changes_comm.Parameters["@id"].Value = Convert.ToInt32(trick.Text);
                save_changes_comm.Parameters["@date_start"].Value = dateTimePicker1.Value;
                save_changes_comm.Parameters["@date_end"].Value = dateTimePicker2.Value;
                save_changes_comm.Parameters["@place"].Value = textBox1.Text;

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
