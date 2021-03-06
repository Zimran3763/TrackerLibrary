﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public Decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTEams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MacthupModel>> Rounds { get; set; } = new List<List<MacthupModel>>();

    }
}
