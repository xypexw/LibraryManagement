using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace CodeX
{
    public partial class TestForm : KryptonForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FindBT_Click(object sender, EventArgs e)
        {
            FindForm form = new FindForm();   
            form.ShowDialog();
            this.Hide();
        }
    }
}
