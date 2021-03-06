//edits made during Step7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//second comment during Step7
namespace GamesScoresLibrary
{
    public class Games
    {
        public string Team1 { get; set; }
        public int Team1score { get; set; }
        public string Team2 { get; set; }
        public int Team2score { get; set; }

        public Games() { }//Step10 Master code 

        public Games(string Team1, int Team1score, string Team2, int Team2score)
        {
            this.Team1 = Team1;
            this.Team1score = Team1score;
            this.Team2 = Team2;
            this.Team2score = Team2score;
        }

        public override string ToString()
        {
            string score1 = "(" + Team1score + ")";
            string hyphen = " - ";
            string score2 = "(" + Team2score + ")";//Creating conflict part with resolution
            //Step 10 modify code

            return string.Format("{0} {1} {2} {3} {4}", Team1, score1, hyphen, Team2, score2);
        }

    }
}

