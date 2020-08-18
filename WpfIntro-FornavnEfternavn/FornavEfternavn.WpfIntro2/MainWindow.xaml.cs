using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FornavEfternavn.WpfIntro2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        Random rnd = new Random();

        private void ChangeMargin_Click(object sender, RoutedEventArgs e)
        {
            double width = this.Width - ChangeMargin.ActualWidth;
            double height = this.Height - ChangeMargin.ActualHeight;
            double left = rnd.Next(0, (int)width/2);
            double right = rnd.Next(0, (int)width / 2);
            double top = rnd.Next(0-(int)ChangeMargin.ActualHeight, (int)(height - (ChangeMargin.ActualHeight *2)));
            if(left > width || right > width)
            {
                left = 0;
                right = 0;
            }
            ChangeMargin.Margin = new Thickness(left, top, right, 0);
            int score = int.Parse(scoreLabel.Text)+1;
            scoreLabel.Text = score.ToString();
        }
    }
}
