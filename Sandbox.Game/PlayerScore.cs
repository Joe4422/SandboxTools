using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class PlayerScore
    {
        public class Entry
        {
            public int Id { get; }

            public T Get<T>(string id, T a = default)
            {
                throw new NotImplementedException();
            }

            public string GetString(string id, string a = default)
            {
                throw new NotImplementedException();
            }
        }

        public static List<Player> All { get; }

        public delegate void PlayerAddedEventHandler(Entry entry);
        public delegate void PlayerRemovedEventHandler(Entry entry);
        public delegate void PlayerUpdatedEventHandler(Entry entry);

        public static event PlayerAddedEventHandler OnPlayerAdded;
        public static event PlayerRemovedEventHandler OnPlayerRemoved;
        public static event PlayerUpdatedEventHandler OnPlayerUpdated;

    }
}
