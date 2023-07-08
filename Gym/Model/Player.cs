namespace Gym.Model
{

    class Player : Member
    {
        private int number { get; set; }

        private int gaols { get; set; }

        private int contractValue { get; set; }

        private string position { get; set; }

        public Player(string name, string national, int age, int number, int gaols, int contractValue, string position) : base(name, national, age)
        {
            this.number = number;
            this.gaols = gaols;
            this.contractValue = contractValue;
            this.position = position;
        }
    }
}
