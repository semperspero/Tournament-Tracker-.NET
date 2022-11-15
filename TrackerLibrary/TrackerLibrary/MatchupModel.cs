using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// 
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
