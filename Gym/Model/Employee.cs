using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

        public override void Save()
        {
            Random rnd = new Random();

            var Employees = Employee.All();

            string key = Convert.ToString(Employees.Count + rnd.Next(100, 999));
            Employees.Add(key, this);

            this.Store(Employees);
        }

        public override void Edit(string key)
        {
            var Employees = Employee.All();
            if (Employees.ContainsKey(key))
            {
                Employees[key] = this;

                this.Store(Employees);
            }
        }

        public override void Delete(string key)
        {
            var Employees = Employee.All();
            if (Employees.ContainsKey(key))
            {
                Employees.Remove(key);

                this.Store(Employees);
            }
        }

        public static Employee Show(string key)
        {
            var Employees = Employee.All();
            if (Employees.ContainsKey(key))
            {
                return Employees[key];
            }

            return null;
        }

        public static Dictionary<string, Employee> All()
        {
            return JsonSerializer.Deserialize<Dictionary<string, Employee>>(File.ReadAllText(Path.GetFullPath(Storage)));
        }

        private void Store(Dictionary<string, Employee> Employees)
        {
            File.WriteAllText(Storage, JsonSerializer.Serialize(Employees));
        }
    }
}