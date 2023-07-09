using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

        public override void Save()
        {
            Random rnd = new Random();

            var Players = Player.All();

            string key = Convert.ToString(Players.Count + rnd.Next(100, 999));
            Players.Add(key, this);

            this.Store(Players);
        }

        public override void Edit(string key)
        {
            var Players = Player.All();
            if (Players.ContainsKey(key))
            {
                Players[key] = this;

                this.Store(Players);
            }
        }

        public override void Delete(string key)
        {
            var Players = Player.All();
            if (Players.ContainsKey(key))
            {
                Players.Remove(key);

                this.Store(Players);
            }
        }

        public static Player Show(string key)
        {
            var Players = Player.All();
            if (Players.ContainsKey(key))
            {
                return Players[key];
            }

            return null;
        }

        public static Dictionary<string, Player> All()
        {
            return JsonSerializer.Deserialize<Dictionary<string, Player>>(File.ReadAllText(Path.GetFullPath(Storage)));
        }

        private void Store(Dictionary<string, Player> Players)
        {
            File.WriteAllText(Storage, JsonSerializer.Serialize(Players));
        }
    }
}
