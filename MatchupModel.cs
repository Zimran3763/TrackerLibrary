using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryMOdel> Entries { get; set; } = new List<MatchupEntryMOdel>();
        public TeamModel Winner { get; set; }
        public int MacthupRound { get; set; }
    }
}
