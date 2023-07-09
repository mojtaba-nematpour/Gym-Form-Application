using System.Collections.Generic;

namespace Gym.Model
{
    interface MemberInterface
    {
        void Save();

        void Edit(string key);

        void Delete(string key);
    }
}
