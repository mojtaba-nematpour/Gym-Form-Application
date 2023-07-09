using System;
using System.Windows.Forms;
using Gym.Model;

namespace Gym
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeSaveBtn_Click(object sender, EventArgs e)
        {
            string Name = EmployeeNameTb.Text, National = EmployeeNationalTb.Text, PersonalCode = EmployeePerCodeTb.Text, Position = EmployeePositionTb.Text;
            int Age = 0, Salary = 0;

            int.TryParse(EmployeeAgeTb.Text, out Age);
            int.TryParse(EmployeeSalaryTb.Text, out Salary);

            if (EmployeeSaveBtn.Text == "ذخیره")
            {
                Employee Employee = new Employee(Name, National, Age, PersonalCode, Position, Salary);
                Employee.Save();

                this.Close();
            }

            if (EmployeeSaveBtn.Text == "ویرایش")
            {
                Employee Employee = new Employee(Name, National, Age, PersonalCode, Position, Salary);
                Employee.Edit(AccessibleName);

                this.Close();
            }
        }

        private void EmployeeRmBtn_Click(object sender, EventArgs e)
        {
            string Name = EmployeeNameTb.Text, National = EmployeeNationalTb.Text, PersonalCode = EmployeePerCodeTb.Text, Position = EmployeePositionTb.Text;
            int Age = 0, Salary = 0;

            int.TryParse(EmployeeAgeTb.Text, out Age);
            int.TryParse(EmployeeSalaryTb.Text, out Salary);

            Employee Employee = new Employee(Name, National, Age, PersonalCode, Position, Salary);
            Employee.Delete(AccessibleName);

            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (AccessibleName == null)
            {
                EmployeeRmBtn.Hide();

                return;
            }

            Employee Employee = Employee.Show(AccessibleName);

            EmployeeNameTb.Text = Employee.Name;
            EmployeeNationalTb.Text = Employee.National;
            EmployeePerCodeTb.Text = Employee.PersonnelCode;
            EmployeePositionTb.Text = Employee.Position;
            EmployeeAgeTb.Text = Convert.ToString(Employee.Age);
            EmployeeSalaryTb.Text = Convert.ToString(Employee.Salary);

            EmployeeFormTitle.Text = "ویرایش کارمند" + " " + AccessibleDescription;
            EmployeeSaveBtn.Text = "ویرایش";
        }
    }
}
