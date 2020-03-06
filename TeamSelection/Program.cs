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
            IStrategyBehaviour standard = new StandardStrategy(4, 4, 2, t.Players);
            IStrategyBehaviour best = new BestSrategy(4, 4, 2, t.Players);
            IStrategyBehaviour rotation = new RotationStrategy(4, 4, 2, t.Players);



            Strategy strategy = new Strategy(best, 4, 4, 2, t.Players);
            List<Player> eindlijst = strategy.Select();
            foreach (Player player in eindlijst)
            {
                Console.WriteLine(player.ToString());
            }
        }
    }
}
