namespace Gym.Model
{
    public class Coach : Member
    {
        public string Field { get; set; }

        public int ContractValue { get; set; }

        public static string Storage = "../../Storage/Coaches.json";

        public Coach(string Name, string National, int Age, string Field, int ContractValue) : base(Name, National, Age)
        {
            this.Field = Field;
            this.ContractValue = ContractValue;
        }
    }
}