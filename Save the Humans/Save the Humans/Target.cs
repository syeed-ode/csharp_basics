using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;

namespace Save_the_Humans
{
    public partial class MainWindow : Window
    {
        DispatcherTimer targetTimer = new DispatcherTimer();

        private void TargetTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if(progressBar.Value >= progressBar.Maximum)
            {
                EndTheGame();
            }
        }

        private void EndTheGame()
        {
            if(!playArea.Children.Contains(gameOverText))
            {
                enemyTimer.Stop();
                targetTimer.Stop();
                humanCaptured = false;
                startButton.Visibility = Visibility.Visible;
                playArea.Children.Add(gameOverText);
            }
        }
    }
}
