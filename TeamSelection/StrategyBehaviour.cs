using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public abstract class StrategyBehaviour : IStrategyBehaviour
    {

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            throw new NotImplementedException();
        }
    }
}
