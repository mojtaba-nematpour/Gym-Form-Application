namespace Gym.Model
{
    class Coach : Member
    {
        public string field { get; set; }

        private int contractValue { get; set; }

        public Coach(string name, string national, int age, string field, int contractValue) : base(name, national, age)
        {
            this.field = field;
            this.contractValue = contractValue;
        }
    }
}