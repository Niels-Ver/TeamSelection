using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamSelectie
{
    public class StandardStrategy : IStrategyBehaviour
    {
        public Func<Player, int> orderMethod { get; set; }
        public StandardStrategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList, Func<Player, int> orderMethod)
        {
            this.orderMethod = orderMethod;
        }

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(teamList.OfType<Defender>().OrderByDescending(orderMethod).Take(numberOfDefenders));
            finishedTeamList.AddRange(teamList.OfType<Midfielder>().OrderByDescending(orderMethod).Take(numberOfMidFielders));
            finishedTeamList.AddRange(teamList.OfType<Forward>().OrderByDescending(orderMethod).Take(numberOfForwards));
            finishedTeamList.Add(teamList.OfType<Goalkeeper>().OrderByDescending(orderMethod).First());

            return finishedTeamList;
        }
    }
}
