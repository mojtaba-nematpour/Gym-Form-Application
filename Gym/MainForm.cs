using System;
using Gym.Model;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
        }

        private void CoachAddBtn_Click(object sender, EventArgs e)
        {
            new CoachForm().Show();
        
        }

        private void PlayerAddBtn_Click(object sender, EventArgs e)
        {
            new PlayerForm().Show();
        }
    }
}
