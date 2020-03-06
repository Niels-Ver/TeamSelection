using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public interface IStrategyBehaviour
    {
        List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards);
    }
}
