using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_In_Play
{
    class Pitcher
    {

        public ObservableCollection<string> PitcherSays { get; internal set; }
        private int pitchNumber = 0;

        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;

            BallEventArgs ballEventArgs = e as BallEventArgs;

            if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                CatchBall();
            else
                CoverFirstBase();
        }

        private void CatchBall()
        {
            PitcherSays.Add("Pitch #" + pitchNumber + ": I caught the ball");
        }

        private void CoverFirstBase()
        {
            throw new NotImplementedException("Pithc #" + pitchNumber 
                + ": I covered first base");
        }
    }
}
