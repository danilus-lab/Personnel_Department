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
    public partial class Archive_list : Form
    {
        public Archive_list()
        {
            InitializeComponent();
        }

        private void archiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.otdel_kadrovDataSet);

        }

        private void Archive_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter.Fill(this.otdel_kadrovDataSet.Archive);

        }
    }
}
