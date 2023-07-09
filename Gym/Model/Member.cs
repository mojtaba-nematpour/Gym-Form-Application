using System;
using System.Collections.Generic;

namespace Gym.Model
{
    public abstract class Member: MemberInterface
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

        public abstract void Save();

        public abstract void Edit(string key);

        public abstract void Delete(string key);
    }
}
