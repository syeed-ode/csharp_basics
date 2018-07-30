using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Save_the_Humans
{
    partial class MainWindow : Window
    {
        private void grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
            {
                Point pointerPosition = e.GetPosition(null);
                Point relativePosition = grid
                                          .TransformToVisual(playArea)
                                          .Transform(pointerPosition);
                if ((
                       Math.Abs(relativePosition.X - Canvas.GetLeft(human))
                         > human.ActualWidth * 3
                    )
                 || (
                       Math.Abs(relativePosition.Y - Canvas.GetTop(human)) 
                        > human.ActualHeight * 3
                    )
                   )
                {
                    humanCaptured = false;
                    human.IsHitTestVisible = true;
                }
                else
                {
                    Canvas.SetLeft(human, relativePosition.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relativePosition.Y - human.ActualHeight / 2);
                }

            }
        }

        private void grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (humanCaptured)
                EndTheGame();
        }
    }
}
