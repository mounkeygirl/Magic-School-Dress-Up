using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test003
{
    
    public enum MINIGAME_GAMES
    {
        DRESSUP_CONTEST

    }

    public class Minigame
    {
        


        public Minigame(MINIGAME_GAMES minigameType, Hero hero,int minimumScore=0, string loserMessage = "You have lost. Please try again")
        {
            TypeOfGame = minigameType;
            LoserMessage = loserMessage;
            CurrentHero = hero;
            MinimumScore = minimumScore;
        }

        //return true if minigame is won, and false if it is lost
        public void start()
        {
            //will calculate a score based on actions in minigame
            int score = 0;

            if (TypeOfGame == MINIGAME_GAMES.DRESSUP_CONTEST) {
                DressUpContest newContest = new DressUpContest(this);

                newContest.ShowDialog();

                if (newContest.Score >= MinimumScore)
                {
                    Won = true;
                }
                else
                {
                    Won = false;
                }

            }


        }

        public int MinimumScore
        {
            get;
            set;
        }

        public bool Won
        {
            get;
            set;

        }

        public MINIGAME_GAMES TypeOfGame
        {
            get;

        }

        public string LoserMessage
        {
            get;
            set;
        }

        public Hero CurrentHero
        {
            get;
            set;
        }



    }
}
