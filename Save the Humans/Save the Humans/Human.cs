using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Save_the_Humans
{
    public partial class MainWindow : Window
    {
        bool humanCaptured = false;

        private void human_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                human.IsHitTestVisible = false;
            }
        }
    }
}
