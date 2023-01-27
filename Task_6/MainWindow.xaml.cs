using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rect rect_hero;
        Rect rect_obstacle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(hero, Canvas.GetLeft(hero) - 10);
            rect_hero = new Rect(Canvas.GetLeft(hero), Canvas.GetTop(hero), hero.Width, hero.Height);
            rect_obstacle = new Rect(Canvas.GetLeft(obstacle), Canvas.GetTop(obstacle), obstacle.Width, obstacle.Height);

            if (rect_hero.IntersectsWith(rect_obstacle))
            {
                hero.Background = Brushes.Yellow;
            }
            else
            {
                hero.Background = Brushes.White;
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(hero, Canvas.GetLeft(hero) + 10);
            rect_hero = new Rect(Canvas.GetLeft(hero), Canvas.GetTop(hero), hero.Width, hero.Height);
            rect_obstacle = new Rect(Canvas.GetLeft(obstacle), Canvas.GetTop(obstacle), obstacle.Width, obstacle.Height);
            
            if(rect_hero.IntersectsWith(rect_obstacle))
            {
                hero.Background = Brushes.Yellow;
            }
            else
            {
                hero.Background = Brushes.White;
            }
        }
    }
}
