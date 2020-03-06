using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamSelectie
{
    public class RotationStrategy : IStrategyBehaviour
    {
        public RotationStrategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList, Func<Player, int> orderMethod)
        {
        }

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(teamList.OfType<Defender>().OrderBy(w => w.Caps).Take(numberOfDefenders));
            finishedTeamList.AddRange(teamList.OfType<Midfielder>().OrderBy(w => w.Caps).Take(numberOfMidFielders));
            finishedTeamList.AddRange(teamList.OfType<Forward>().OrderBy(w => w.Caps).Take(numberOfForwards));
            finishedTeamList.Add(teamList.OfType<Goalkeeper>().OrderBy(w => w.Caps).First());

            return finishedTeamList;
        }
    }
}
