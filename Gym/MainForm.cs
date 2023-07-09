using System;
using Gym.Model;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Gym
{
    public partial class MainForm : Form
    {
        private string EmployeeCol = "";

        private string CoachCol = "";

        private string PlayerCol = "";

        private bool EmployeeIsSorted = false;

        private bool CoachIsSorted = false;

        private bool PlayerIsSorted = false;

        public MainForm()
        {
            InitializeComponent();

            LoadTabels(true);
        }

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm EmployeeForm = new EmployeeForm();
            EmployeeForm.Show();

            EmployeeForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
        }

        private void CoachAddBtn_Click(object sender, EventArgs e)
        {
            CoachForm CoachForm = new CoachForm();
            CoachForm.Show();

            CoachForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
        }

        private void PlayerAddBtn_Click(object sender, EventArgs e)
        {
            PlayerForm PlayerForm = new PlayerForm();
            PlayerForm.Show();

            PlayerForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTabels();
        }

        private void EmployeeDetailBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            EmployeeForm EmployeeForm = new EmployeeForm();
            EmployeeForm.Text = "ویرایش" + " " + button.AccessibleDescription;
            EmployeeForm.AccessibleName = button.AccessibleName;
            EmployeeForm.AccessibleDescription = button.AccessibleDescription;
            EmployeeForm.Show();

            EmployeeForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
        }

        private void CoachDetailBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            CoachForm CoachForm = new CoachForm();
            CoachForm.Text = "ویرایش" + " " + button.AccessibleDescription;
            CoachForm.AccessibleName = button.AccessibleName;
            CoachForm.AccessibleDescription = button.AccessibleDescription;
            CoachForm.Show();

            CoachForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
        }

        private void PlayerDetailBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            PlayerForm PlayerForm = new PlayerForm();
            PlayerForm.Text = "ویرایش" + " " + button.AccessibleDescription;
            PlayerForm.AccessibleName = button.AccessibleName;
            PlayerForm.AccessibleDescription = button.AccessibleDescription;
            PlayerForm.Show();

            PlayerForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
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

            int row = 1;
            Dictionary<string, Employee> Employees = Employee.All();

            Employees = this.SortEmployees(Employees);
            foreach (var employee in Employees)
            {
                var Employee = employee.Value;
                var Key = employee.Key;

                Button button = new Button();
                button.Text = "نمایش";
                button.AccessibleName = Key;
                button.AccessibleDescription = Employee.Name;
                button.Click += new EventHandler(EmployeeDetailBtn_Click);

                EmployeeTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                EmployeeTable.Controls.Add(new Label() { Text = Key }, 0, row);
                EmployeeTable.Controls.Add(new Label() { Text = Employee.Name }, 1, row);
                EmployeeTable.Controls.Add(new Label() { Text = Employee.National }, 2, row);
                EmployeeTable.Controls.Add(new Label() { Text = Convert.ToString(Employee.Age) }, 3, row);
                EmployeeTable.Controls.Add(new Label() { Text = Employee.PersonnelCode }, 4, row);
                EmployeeTable.Controls.Add(new Label() { Text = Employee.Position }, 5, row);
                EmployeeTable.Controls.Add(new Label() { Text = Convert.ToString(Employee.Salary) }, 6, row);
                EmployeeTable.Controls.Add(button, 7, row);
                EmployeeTable.Height += 50;
                row++;
            }
           
            row = 1;
            Dictionary<string, Coach> Coaches = Coach.All();
            Coaches = this.SortCoaches(Coaches);
            foreach (var coach in Coaches)
            {
                var Coach = coach.Value;
                var Key = coach.Key;

                Button button = new Button();
                button.Text = "نمایش";
                button.AccessibleName = Key;
                button.AccessibleDescription = Coach.Name;
                button.Click += new EventHandler(CoachDetailBtn_Click);

                CoachTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                CoachTable.Controls.Add(new Label() { Text = Key }, 0, row);
                CoachTable.Controls.Add(new Label() { Text = Coach.Name }, 1, row);
                CoachTable.Controls.Add(new Label() { Text = Coach.National }, 2, row);
                CoachTable.Controls.Add(new Label() { Text = Convert.ToString(Coach.Age) }, 3, row);
                CoachTable.Controls.Add(new Label() { Text = Coach.Field }, 4, row);
                CoachTable.Controls.Add(new Label() { Text = Convert.ToString(Coach.ContractValue) }, 5, row);
                CoachTable.Controls.Add(button, 6, row);
                CoachTable.Height += 50;
                row++;
            }
            
            row = 1;
            Dictionary<string, Player> Players = Player.All();
            Players = this.SortPlayers(Players);
            foreach (var player in Players)
            {
                var Player = player.Value;
                var Key = player.Key;

                Button button = new Button();
                button.Text = "نمایش";
                button.AccessibleName = Key;
                button.AccessibleDescription = Player.Name;
                button.Click += new EventHandler(PlayerDetailBtn_Click);

                PlayerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                PlayerTable.Controls.Add(new Label() { Text = Key }, 0, row);
                PlayerTable.Controls.Add(new Label() { Text = Player.Name }, 1, row);
                PlayerTable.Controls.Add(new Label() { Text = Player.National }, 2, row);
                PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.Age) }, 3, row);
                PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.Gaols) }, 4, row);
                PlayerTable.Controls.Add(new Label() { Text = Convert.ToString(Player.ContractValue) }, 5, row);
                PlayerTable.Controls.Add(new Label() { Text = Player.Position }, 6, row);
                PlayerTable.Controls.Add(button, 7, row);
                PlayerTable.Height += 50;
                row++;
            }
            
        }

        private void EmployeeSortId_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "id");
            this.EmployeeCol = "id";

            LoadTabels();
        }

        private void EmployeeSortName_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "Name");
            this.EmployeeCol = "Name";

            LoadTabels();
        }

        private void EmployeeSortNational_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "National");
            this.EmployeeCol = "National";

            LoadTabels();
        }

        private void EmployeeSortAge_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "Age");
            this.EmployeeCol = "Age";

            LoadTabels();
        }

        private void EmployeeSortPerCode_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "PerCode");
            this.EmployeeCol = "PerCode";

            LoadTabels();
        }

        private void EmployeeSortPosition_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "Position");
            this.EmployeeCol = "Position";

            LoadTabels();
        }

        private void EmployeeSortSalary_Click(object sender, EventArgs e)
        {
            CheckIsSorted("employee", "Salary");
            this.EmployeeCol = "Salary";

            LoadTabels();
        }

        private void CoachSortId_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "id");
            this.CoachCol = "id";

            LoadTabels();
        }

        private void CoachSortName_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "Name");
            this.CoachCol = "Name";

            LoadTabels();
        }

        private void CoachSortNational_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "National");
            this.CoachCol = "National";

            LoadTabels();
        }

        private void CoachSortAge_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "Age");
            this.CoachCol = "Age";

            LoadTabels();
        }

        private void CoachSortField_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "Field");
            this.CoachCol = "Field";

            LoadTabels();
        }

        private void CoachSortContractValue_Click(object sender, EventArgs e)
        {
            CheckIsSorted("coach", "ContractValue");
            this.CoachCol = "ContractValue";

            LoadTabels();
        }

        private void PlayerSortId_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "id");
            this.PlayerCol = "id";

            LoadTabels();
        }

        private void PlayerSortName_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "Name");
            this.PlayerCol = "Name";

            LoadTabels();
        }

        private void PlayerSortNational_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "National");
            this.PlayerCol = "National";

            LoadTabels();
        }

        private void PlayerSortAge_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "Age");
            this.PlayerCol = "Age";

            LoadTabels();
        }

        private void PlayerSortGoals_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "Goals");
            this.PlayerCol = "Goals";

            LoadTabels();
        }

        private void PlayerSortContractValue_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "ContractValue");
            this.PlayerCol = "ContractValue";

            LoadTabels();
        }

        private void PlayerSortPosition_Click(object sender, EventArgs e)
        {
            CheckIsSorted("player", "Position");
            this.PlayerCol = "Position";

            LoadTabels();
        }

        private void CheckIsSorted(string member, string current)
        {
            switch(member)
            {
                case "employee":
                    if (EmployeeCol == current)
                    {
                        if (!EmployeeIsSorted)
                            EmployeeIsSorted = true;
                    }

                    EmployeeIsSorted = false;
                    break;
                case "coach":
                    if (CoachCol == current)
                    {
                        if (!CoachIsSorted)
                            CoachIsSorted = true;
                    }

                    CoachIsSorted = false;
                    break;
                case "player":
                    if (PlayerCol == current)
                    {
                        if (!PlayerIsSorted)
                            PlayerIsSorted = true;
                    }

                    PlayerIsSorted = false;
                    break;
            }

            Console.WriteLine(member + ";" + current);
        }

        private Dictionary<string, Employee> SortEmployees(Dictionary<string, Employee> Employees)
        {
            Dictionary<string, Employee> employees;
            switch (this.EmployeeCol)
            {
                case "id":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Key).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Key).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Name":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.Name).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.Name).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "National":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.National).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.National).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Age":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.Age).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.Age).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "PerCode":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.PersonnelCode).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.PersonnelCode).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Position":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.Position).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.Position).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Salary":
                    employees = this.EmployeeIsSorted ? Employees.OrderBy(e => e.Value.Salary).ToDictionary(e => e.Key, e => e.Value) : Employees.OrderByDescending(e => e.Value.Salary).ToDictionary(e => e.Key, e => e.Value);
                    break;
                default:
                    employees = Employees;
                    break;
            }

            return employees;
        }

        private Dictionary<string, Coach> SortCoaches(Dictionary<string, Coach> Coaches)
        {
            Dictionary<string, Coach> coaches;
            switch (this.CoachCol)
            {
                case "id":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Key).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Key).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Name":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Value.Name).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Value.Name).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "National":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Value.National).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Value.National).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Age":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Value.Age).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Value.Age).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Field":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Value.Field).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Value.Field).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "ContractValue":
                    coaches = this.CoachIsSorted ? Coaches.OrderBy(c => c.Value.ContractValue).ToDictionary(e => e.Key, e => e.Value) : Coaches.OrderByDescending(c => c.Value.ContractValue).ToDictionary(e => e.Key, e => e.Value);
                    break;
                default:
                    coaches = Coaches;
                    break;
            }

            return coaches;
        }

        private Dictionary<string, Player> SortPlayers(Dictionary<string, Player> Players)
        {
            Dictionary<string, Player> players;
            switch (this.PlayerCol)
            {
                case "id":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Key).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Key).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Name":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.Name).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.Name).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "National":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.National).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.National).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Age":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.Age).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.Age).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Goals":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.Gaols).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.Gaols).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "ContractValue":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.ContractValue).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.ContractValue).ToDictionary(e => e.Key, e => e.Value);
                    break;
                case "Position":
                    players = this.PlayerIsSorted ? Players.OrderBy(p => p.Value.Position).ToDictionary(e => e.Key, e => e.Value) : Players.OrderByDescending(p => p.Value.Position).ToDictionary(e => e.Key, e => e.Value);
                    break;
                default:
                    players = Players;
                    break;
            }

            return players;
        }
    }
}
