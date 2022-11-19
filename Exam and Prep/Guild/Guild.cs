using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Player curp = roster.FirstOrDefault(x => x.Name == name);
            if (curp == null)
            {
                return false;
            }
            else
            {
                roster.Remove(curp);
                return true;
            }
        }
        public void PromotePlayer(string name)
        {
            Player curp = roster.FirstOrDefault(x => x.Name == name);
            if (curp.Rank == "Trial")
            {
                curp.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            Player curp = roster.FirstOrDefault(x => x.Name == name);
            if (curp.Rank == "Member")
            {
                curp.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string classs)
        {

            Player[] players = roster.Where(x => x.Class == classs).ToArray();
            roster.RemoveAll(x => x.Class == classs);
            return players;

            return players;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }

}
