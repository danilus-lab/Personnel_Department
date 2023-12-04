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
    public partial class Change_dep_boss : Form
    {
        public Change_dep_boss(string dep)
        {
            InitializeComponent();

            trick.Text = dep;

            workerBindingSource.Filter = "Dep = " + dep;
        }

        private void Change_dep_boss_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.otdel_kadrovDataSet.Worker);

        }

        private void set_boss_button_Click(object sender, EventArgs e)
        {
            int id_boss = Convert.ToInt32(listBox1.SelectedValue);

            sqlConnection1.Open();

            set_boss_comm.Parameters["@dep"].Value = Convert.ToInt32(trick.Text);
            set_boss_comm.Parameters["@boss_id"].Value = id_boss;
            
            set_boss_comm.ExecuteNonQuery();

            sqlConnection1.Close();

            string result = Convert.ToString(set_boss_comm.Parameters["@message"].Value);
            MessageBox.Show(result);
        }
    }
}
