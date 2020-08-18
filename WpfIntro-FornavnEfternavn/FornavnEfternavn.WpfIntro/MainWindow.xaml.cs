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

namespace FornavnEfternavn.WpfIntro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Du trykkede på knappen";
            MessageBox.Show(message);
        }

        private void changeColor_Click(object sender, RoutedEventArgs e)
        {
            changeColor.Background = Brushes.Green;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int cookieClickerData = int.Parse(cokkieClickerText.Text)+1;
            cokkieClickerText.Text = cookieClickerData.ToString();
        }

        private void arrowUp_Click(object sender, RoutedEventArgs e)
        {
            int arrowCodeData = int.Parse(arrowData.Text)+1;
            arrowData.Text = arrowCodeData.ToString();
            int totalClicks = int.Parse(totalClicksData.Text)+1;
            totalClicksData.Text = totalClicks.ToString();
        }

        private void arrowDown_Click(object sender, RoutedEventArgs e)
        {
            int arrowCodeData = int.Parse(arrowData.Text) - 1;
            arrowData.Text = arrowCodeData.ToString();
            int totalClicks = int.Parse(totalClicksData.Text) + 1;
            totalClicksData.Text = totalClicks.ToString();
        }

        private void nameBtn_Click(object sender, RoutedEventArgs e)
        {
            string sayHello = $"Hej {firstNameInput.Text} {lastNameInput.Text} og velkommen til programmet!";
            MessageBox.Show(sayHello);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textInput = changeTextBox.Text;
            changeMe.Text = textInput;
        }
    }
}
