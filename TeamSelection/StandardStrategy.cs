using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamSelectie
{
    public class StandardStrategy : IStrategyBehaviour
    {
        public StandardStrategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList)
        {
        }

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(teamList.OfType<Defender>().OrderByDescending(w => w.Caps).Take(numberOfDefenders));
            finishedTeamList.AddRange(teamList.OfType<Midfielder>().OrderByDescending(w => w.Caps).Take(numberOfMidFielders));
            finishedTeamList.AddRange(teamList.OfType<Forward>().OrderByDescending(w => w.Caps).Take(numberOfForwards));
            finishedTeamList.Add(teamList.OfType<Goalkeeper>().OrderByDescending(w => w.Caps).First());

            return finishedTeamList;
        }
    }
}
