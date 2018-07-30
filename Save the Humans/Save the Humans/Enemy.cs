using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Save_the_Humans
{
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            AddEnemy();
        }

        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, (int)playArea.ActualWidth - 100, "(Canvas.Left)");

            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight - 100)
                , random.Next((int)playArea.ActualHeight - 100)
                , "(Canvas.Top)");

            playArea.Children.Add(enemy);
        }

        private void AnimateEnemy(ContentControl enemy, double startPosition, double endPosition, string animationProperty)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };

            DoubleAnimation animation = new DoubleAnimation()
            {
                From = startPosition,
                To = endPosition,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
            };

            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(animationProperty));
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
    }
}
