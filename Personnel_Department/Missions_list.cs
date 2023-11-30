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
    public partial class Missions_list : Form
    {
        public Missions_list()
        {
            InitializeComponent();

            sqlConnection1.Open();
            var temp = new DataTable();

            temp.Load(fill_the_table_comm.ExecuteReader());

            dataGridView1.DataSource = temp;

            sqlConnection1.Close();
        }
    }
}
