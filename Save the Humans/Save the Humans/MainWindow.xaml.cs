using System;
using System.Windows;
using System.Windows.Threading;

namespace Save_the_Humans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool humanCaptured = false;

        public MainWindow()
        {
            InitializeComponent();

            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += TargetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
        }
    }
}
