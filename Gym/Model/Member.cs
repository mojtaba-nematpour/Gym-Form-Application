namespace Gym.Model
{
    abstract class Member
    {
        protected string name { get; set; }

        protected string nationalCode { get; set; }

        protected int age { get; set; }

        public Member(string name, string national, int age)
        {
            this.name = name;
            this.nationalCode = national;
            this.age = age;
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
