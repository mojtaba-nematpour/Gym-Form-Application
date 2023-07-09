namespace Gym.Model
{
    public class Employee : Member
    {
        public string PersonnelCode { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public static string Storage = "../../Storage/Employees.json";

        public Employee(string Name, string National, int Age, string PersonnelCode, string Position, int Salary) : base(Name, National, Age)
        {
            this.PersonnelCode = PersonnelCode;
            this.Position = Position;
            this.Salary = Salary;
        }
    }
}