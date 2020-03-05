using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamSelectie
{
    public class Strategy
    {
        public int numberOfDefenders { get; set; }
        public int numberOfMidFielders { get; set; }
        public int numberOfForwards { get; set; }

        List<Player> teamList = new List<Player>();

        List<Player> defenderList = new List<Player>();
        List<Player> midFielderList = new List<Player>();
        List<Player> forwardList = new List<Player>();
        List<Player> goalKeeperList = new List<Player>();

        public Strategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList)
        {
            this.numberOfDefenders = numberOfDefenders;
            this.numberOfMidFielders = numberOfMidFielders;
            this.numberOfForwards = numberOfForwards;
            this.teamList = teamList;

            makePlayerList();
        }

        public void makePlayerList()
        {

            defenderList.AddRange(teamList.OfType<Defender>());
            midFielderList.AddRange(teamList.OfType<Midfielder>());
            forwardList.AddRange(teamList.OfType<Forward>());
            goalKeeperList.AddRange(teamList.OfType<Goalkeeper>());

        }


        //List<string> vervangen door List<speler>
        public List<Player> StandardSelection()
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(defenderList.OrderBy(w => w.Caps).Take(numberOfDefenders));
            finishedTeamList.AddRange(midFielderList.OrderBy(w => w.Caps).Take(numberOfMidFielders));
            finishedTeamList.AddRange(forwardList.OrderBy(w => w.Caps).Take(numberOfForwards));
            finishedTeamList.Add(goalKeeperList.OrderBy(w => w.Caps).First());

            return finishedTeamList;
        }

        public List<Player> BestSelection()
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(defenderList.OrderBy(w => w.Rating).Take(numberOfDefenders));
            finishedTeamList.AddRange(midFielderList.OrderBy(w => w.Rating).Take(numberOfMidFielders));
            finishedTeamList.AddRange(forwardList.OrderBy(w => w.Rating).Take(numberOfForwards));
            finishedTeamList.Add(goalKeeperList.OrderBy(w => w.Rating).First());

            return finishedTeamList;
        }
        public List<Player> RotationSelection()
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(defenderList.OrderByDescending(w => w.Caps).Take(numberOfDefenders));
            finishedTeamList.AddRange(midFielderList.OrderByDescending(w => w.Caps).Take(numberOfMidFielders));
            finishedTeamList.AddRange(forwardList.OrderByDescending(w => w.Caps).Take(numberOfForwards));
            finishedTeamList.Add(goalKeeperList.OrderByDescending(w => w.Caps).First());

            return finishedTeamList;
        }
    }
}
