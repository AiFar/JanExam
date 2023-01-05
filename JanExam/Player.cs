using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    internal class Player
    {
        #region properties
        public string Name { get;  set; }
        public string ResultRecord { get;  set; }

        #endregion properties

        #region constructor
        public Player (string name, string resultRecord)
        {
            Name = name;
            ResultRecord = resultRecord;

        }

        public Player()
        {

        }
        #endregion constructor
        //public Player(string name, string resultRecord) : this(name, resultRecord) { }
    }
}
