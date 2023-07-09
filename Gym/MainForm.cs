using System;
using Gym.Model;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace Gym
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadTabels(true);
        }

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm EmployeeForm = new EmployeeForm();
            EmployeeForm.Show();

            this.Close();
        }

        private void CoachAddBtn_Click(object sender, EventArgs e)
        {
            CoachForm CoachForm = new CoachForm();
            CoachForm.Show();

            this.Close();
        }

        private void PlayerAddBtn_Click(object sender, EventArgs e)
        {
            PlayerForm PlayerForm = new PlayerForm();
            PlayerForm.Show();

            this.Close();
        }

        public void LoadTabels(bool init = false)
        {
            if (!init)
            {
                EmployeeTable.Controls.Clear();
                EmployeeTable.RowStyles.Clear();
                EmployeeTable.RowCount = 1;

                CoachTable.Controls.Clear();
                CoachTable.RowStyles.Clear();
                CoachTable.RowCount = 1;

                PlayerTable.Controls.Clear();
                PlayerTable.RowStyles.Clear();
                PlayerTable.RowCount = 1;
            }

            string EmployeesJson = File.ReadAllText(Path.GetFullPath(Employee.Storage));
            if (EmployeesJson != "{}")
            {
                var Employees = JsonSerializer.Deserialize<Dictionary<string, Employee>>(EmployeesJson);

                int row = 1;
                foreach (var employee in Employees)
                {
                    var Employee = employee.Value;
                    var Key = employee.Key;

                    EmployeeTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    EmployeeTable.Controls.Add(new Label() { Text = Key }, 0, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Employee.Name }, 1, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Employee.National }, 2, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Convert.ToString(Employee.Age) }, 3, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Employee.PersonnelCode }, 4, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Employee.Position }, 5, row);
                    EmployeeTable.Controls.Add(new Label() { Text = Convert.ToString(Employee.Salary) }, 6, row);
                    EmployeeTable.Height += 50;
                    row++;
                }
            }

            string CoachesJson = File.ReadAllText(Path.GetFullPath(Coach.Storage));
            if (CoachesJson != "{}")
            {
                var Coaches = JsonSerializer.Deserialize<Dictionary<string, Coach>>(CoachesJson);

                int row = 1;
                foreach (var coach in Coaches)
                {
                    var Coach = coach.Value;
                    var Key = coach.Key;

                    CoachTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    CoachTable.Controls.Add(new Label() { Text = Key }, 0, row);
                    CoachTable.Controls.Add(new Label() { Text = Coach.Name }, 1, row);
                    CoachTable.Controls.Add(new Label() { Text = Coach.National }, 2, row);
                    CoachTable.Controls.Add(new Label() { Text = Convert.ToString(Coach.Age) }, 3, row);
                    CoachTable.Controls.Add(new Label() { Text = Coach.Field }, 4, row);
                    CoachTable.Controls.Add(new Label() { Text = Convert.ToString(Coach.ContractValue) }, 5, row);
                    CoachTable.Height += 50;
                    row++;
                }
            }

            string PlayersJson = File.ReadAllText(Path.GetFullPath(Player.Storage));
            if (PlayersJson != "{}")
            {
                var Players = JsonSerializer.Deserialize<Dictionary<string, Player>>(PlayersJson);

                int row = 1;
                foreach (var player in Players)
                {
                    var Player = player.Value;
                    var Key = player.Key;

                    PlayerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    PlayerTable.Controls.Add(new Label() { Text = Key }, 0, row);
                    PlayerTable.Controls.Add(new Label() { Text = Player.Name }, 1, row);
                    PlayerTable.Controls.Add(new Label() { Text = Player.National }, 2, row);
                    PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.Age) }, 3, row);
                    PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.Gaols) }, 4, row);
                    PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.ContractValue) }, 5, row);
                    PlayerTable.Controls.Add(new Label() { Text = Player.Position }, 6, row);
                    PlayerTable.Height += 50;
                    row++;
                }
            }
        }
    }
}
