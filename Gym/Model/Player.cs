namespace Gym.Model
{

    public class Player : Member
    {
        public int Number { get; set; }

        public int Gaols { get; set; }

        public int ContractValue { get; set; }

        public string Position { get; set; }

        public static string Storage = "../../Storage/Players.json";

        public Player(string Name, string National, int Age, int Number, int Gaols, int ContractValue, string Position) : base(Name, National, Age)
        {
            this.Number = Number;
            this.Gaols = Gaols;
            this.ContractValue = ContractValue;
            this.Position = Position;
        }
    }
}
