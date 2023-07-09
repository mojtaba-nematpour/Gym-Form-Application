using System;
using System.Windows.Forms;
using Gym.Model;

namespace Gym
{
    public partial class CoachForm : Form
    {
        public CoachForm()
        {
            InitializeComponent();
        }

        private void CoachSaveBtn_Click(object sender, EventArgs e)
        {
            string Name = CoachNameTb.Text, National = CoachNationalTb.Text, Field = CoachFieldTb.Text;
            int Age = 0, ContractValue = 0;

            int.TryParse(CoachAgeTb.Text, out Age);
            int.TryParse(CoachContractValueTb.Text, out ContractValue);

            if (CoachSaveBtn.Text == "ذخیره")
            {
                Coach Coach = new Coach(Name, National, Age, Field, ContractValue);
                Coach.Save();

                this.Close();
            }

            if (CoachSaveBtn.Text == "ویرایش")
            {
                Coach Coach = new Coach(Name, National, Age, Field, ContractValue);
                Coach.Edit(AccessibleName);

                this.Close();
            }
        }

        private void CoachRmBtn_Click(object sender, EventArgs e)
        {
            string Name = CoachNameTb.Text, National = CoachNationalTb.Text, Field = CoachFieldTb.Text;
            int Age = 0, ContractValue = 0;

            int.TryParse(CoachAgeTb.Text, out Age);
            int.TryParse(CoachContractValueTb.Text, out ContractValue);

            Coach Coach = new Coach(Name, National, Age, Field, ContractValue);
            Coach.Delete(AccessibleName);

            this.Close();
        }

        private void CoachForm_Load(object sender, EventArgs e)
        {
            if (AccessibleName == null)
            {
                CoachRmBtn.Hide();

                return;
            }

            Coach Coach = Coach.Show(AccessibleName);

            CoachNameTb.Text = Coach.Name;
            CoachNationalTb.Text = Coach.National;
            CoachFieldTb.Text = Coach.Field;
            CoachAgeTb.Text = Convert.ToString(Coach.Age);
            CoachContractValueTb.Text = Convert.ToString(Coach.ContractValue);

            CoachFormTitle.Text = "ویرایش مربی" + " " + AccessibleDescription;
            CoachSaveBtn.Text = "ویرایش";
        }
    }
}
