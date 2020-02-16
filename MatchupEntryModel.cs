using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCometing { get; set; }
        public double Score { set; get; }
        public MatchupModel ParentMatchup { get; set; }

    }
}
