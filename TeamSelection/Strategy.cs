using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamSelectie
{
    public class Strategy 
    {

        IStrategyBehaviour strategyBehaviour;
        public int numberOfDefenders { get; set; }
        public int numberOfMidFielders { get; set; }
        public int numberOfForwards { get; set; }
        public List<Player> teamList { get; set; }



        public Strategy(IStrategyBehaviour strategyBehaviour, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList):this(numberOfDefenders, numberOfMidFielders, numberOfForwards, teamList )
        {
            this.strategyBehaviour = strategyBehaviour;
        }
        protected Strategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList)
        {
            this.numberOfDefenders = numberOfDefenders;
            this.numberOfMidFielders = numberOfMidFielders;
            this.numberOfForwards = numberOfForwards;
            this.teamList = teamList;
        }

        public List<Player> Select()
        {
            return strategyBehaviour.Select(teamList, numberOfDefenders, numberOfMidFielders, numberOfForwards);
        }
    }
}
