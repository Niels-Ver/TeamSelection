using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamSelectie
{
    public class BestSrategy : IStrategyBehaviour
    {

        public BestSrategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList)
        {
        }

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(teamList.OfType<Defender>().OrderByDescending(w => w.Rating).Take(numberOfDefenders));
            finishedTeamList.AddRange(teamList.OfType<Midfielder>().OrderByDescending(w => w.Rating).Take(numberOfMidFielders));
            finishedTeamList.AddRange(teamList.OfType<Forward>().OrderByDescending(w => w.Rating).Take(numberOfForwards));
            finishedTeamList.Add(teamList.OfType<Goalkeeper>().OrderByDescending(w => w.Rating).First());

            return finishedTeamList;
        }
    }
}
