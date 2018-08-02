using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_In_Play
{
    class Fan
    {
        public ObservableCollection<string> FanSays { get; internal set; }
        private int pitchNumber = 0;

        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;

            BallEventArgs ballEventArgs = e as BallEventArgs;

            if ((ballEventArgs.Distance > 400) && (ballEventArgs.Trajectory > 30))
                GrabGloveCatchBall();
            else
                ScreamAndShout();
        }

        private void GrabGloveCatchBall()
        {
            FanSays.Add("Pitch #" + pitchNumber + ": Home run! I'm going for the ball!");
        }

        private void ScreamAndShout()
        {
            FanSays.Add("Pitch #" + pitchNumber + "Woo-hoo! Yeah!");
        }
    }
}
