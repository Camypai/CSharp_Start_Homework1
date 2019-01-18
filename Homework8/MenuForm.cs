using System;
using System.Windows.Forms;

namespace Homework8
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            var task4 = new Task4();
            task4.Show();
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            var task5 = new Task5();
            task5.Show();
        }
    }
}
