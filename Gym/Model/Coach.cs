using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

        public override void Save()
        {
            Random rnd = new Random();

            var Coaches = Coach.All();

            string key = Convert.ToString(Coaches.Count + rnd.Next(100, 999));
            Coaches.Add(key, this);

            this.Store(Coaches);
        }

        public override void Edit(string key)
        {
            var Coaches = Coach.All();
            if (Coaches.ContainsKey(key))
            {
                Coaches[key] = this;

                this.Store(Coaches);
            }
        }

        public override void Delete(string key)
        {
            var Coaches = Coach.All();
            if (Coaches.ContainsKey(key))
            {
                Coaches.Remove(key);

                this.Store(Coaches);
            }
        }

        public static Coach Show(string key)
        {
            var Coaches = Coach.All();
            if (Coaches.ContainsKey(key))
            {
                return Coaches[key];
            }

            return null;
        }

        public static Dictionary<string, Coach> All()
        {     
            return JsonSerializer.Deserialize<Dictionary<string, Coach>>(File.ReadAllText(Path.GetFullPath(Storage)));
        }

        private void Store(Dictionary<string, Coach> Coaches)
        {
            File.WriteAllText(Storage, JsonSerializer.Serialize(Coaches));
        }
    }
}