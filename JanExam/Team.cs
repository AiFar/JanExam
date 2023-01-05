using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JanExam
{
    internal class Team
    {
        internal IEnumerable team;
        #region properties
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public TextCompositionEventHandler Teams { get; set; }
        #endregion propertites

        #region constructor
        public Team(string name, List<Player> players)
        {
            Name = name;
            players = players.ToList();


        }

        public Team()
        {
        }

        #endregion constructor
    }

    public class Teams : IComparable
    {
        int points = 0;
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();

            if (points == null)
            {

            }

           
        }
    }
}
