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

namespace Task_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plas_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TB_1.Text);
            int b = int.Parse(TB_2.Text);
            int num = a + b;
            label.Content = num;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TB_1.Text);
            int b = int.Parse(TB_2.Text);
            int num = a - b;
            label.Content = num;
        }

        private void slesh_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TB_1.Text);
            int b = int.Parse(TB_2.Text);
            int num = a / b;
            label.Content = num;
        }

        private void umnozg_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TB_1.Text);
            int b = int.Parse(TB_2.Text);
            int num = a * b;
            label.Content = num;
        }
    }
}
