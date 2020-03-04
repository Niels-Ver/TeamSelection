using System;
using System.Collections.Generic;

namespace TeamSelectie
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerFactory p = new PlayerFactory();
            //p.ReadData();
            //List<Speler> spelers = p.ReadData();
            
            Team t = new Team();
            t.Addplayers(p.CreateListPlayers());

            //foreach (var f in t.Players)
            //    Console.WriteLine(f);

            Strategy strategy = new Strategy(4, 4, 2, t.Players);
            strategy.StandardSelection();
        }
    }
}
