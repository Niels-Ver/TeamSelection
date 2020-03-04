using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class Team
    {
        public string TeamNaam {get;set;}
        public List<Player> Players { get; set; }
        public void Addplayers(List<Player> p)
        {
            Players = p;
        }

    }
}
