namespace Gym.Model
{
    class Employee : Member
    {
        private string personnelCode { get; set; }

        private string position { get; set; }

        private int salary { get; set; }

        public Employee(string name, string national, int age, string personnelCode, string position, int salary) : base(name, national, age)
        {
            this.personnelCode = personnelCode;
            this.position = position;
            this.salary = salary;
        }
    }
}