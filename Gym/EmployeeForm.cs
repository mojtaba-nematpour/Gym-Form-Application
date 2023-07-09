using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
