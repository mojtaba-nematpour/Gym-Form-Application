using System;

namespace Gym.Model
{
    public abstract class Member
    {
        public string Name { get; set; }

        public string National { get; set; }

        public int Age { get; set; }

        public Member(string Name, string National, int Age)
        {
            this.Name = Name;
            this.National = National;
            this.Age = Age;
        }

        public static string[] List()
        {
            string[] Table = { };

            return Table;
        }

        public static void Save()
        {

        }

        public static void Edit()
        {

        }

        public static string Show()
        {
            return "";
        }
         
        public static void Delete()
        {

        }
    }
}
