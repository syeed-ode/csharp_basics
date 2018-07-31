using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_In_Play
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
