using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamSelectie
{
    public class PlayerFactory
    {
        public List<Player> CreateListPlayers()
        {
            string line;
            using (StreamReader r = new StreamReader(@"C:\Users\niels\Documents\N\Prog 3\ProjectTeams\rodeDuivels.txt"))
            {
                List<Player> players = new List<Player>();
                while ((line = r.ReadLine()) != null)
                {
                    players.Add(CreatePlayer(line));
                }
                return players;
            }
        }
        public Player CreatePlayer(string value)
        {
            string[] collectie = value.Split(",");
            int nummer = int.Parse(collectie[2]);
            List<String> posities = new List<string>();
            for (int i = 3; i < collectie.Length - 2; i++)
                posities.Add(collectie[i]);
            int rating = int.Parse(collectie[collectie.Length - 2]);
            int caps = int.Parse(collectie[collectie.Length - 1]);

            switch (collectie[0])
            {
                case "GoalKeeper": return new Goalkeeper(collectie[0], collectie[1], nummer, posities, rating, caps);
                case "Defender": return new Defender(collectie[0], collectie[1], nummer, posities, rating, caps);
                case "Forward": return new Forward(collectie[0], collectie[1], nummer, posities, rating, caps);
                case "MidFielder": return new Midfielder(collectie[0], collectie[1], nummer, posities, rating, caps);
                default: throw new ArgumentException("Verkeerde Code Jonge!");
            }
        }

    }
}
