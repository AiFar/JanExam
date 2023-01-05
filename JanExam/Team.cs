using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    internal class Team
    {
        #region properties
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        #endregion propertites

        #region constructor
        public Team(string name, List<Player> players)
        {
            Name = name;
            players = players.ToList();


        }

        #endregion constructor
    }
}
