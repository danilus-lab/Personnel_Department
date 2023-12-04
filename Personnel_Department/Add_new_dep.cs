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
    public partial class Add_new_dep : Form
    {
        public Add_new_dep()
        {
            InitializeComponent();
            
            myConnection.Open();
            textBox1.Text = sqlCommand1.ExecuteScalar().ToString();
            myConnection.Close();
        }

        private void create_dep_button_Click(object sender, EventArgs e)
        {
            myConnection.Open();

            sqlCommand2.Parameters["@dep_num"].Value = Convert.ToInt32(textBox1.Text);

            sqlCommand2.ExecuteNonQuery();

            myConnection.Close();

            string result = Convert.ToString(sqlCommand2.Parameters["@message"].Value);
            MessageBox.Show(result);

        }
    }
}
