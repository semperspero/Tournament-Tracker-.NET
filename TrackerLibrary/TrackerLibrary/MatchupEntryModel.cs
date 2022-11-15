using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
