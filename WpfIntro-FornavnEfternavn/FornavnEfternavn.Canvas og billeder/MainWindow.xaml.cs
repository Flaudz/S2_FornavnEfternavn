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

namespace FornavnEfternavn.Canvas_og_billeder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i;

        public string[] imageSources =
            {
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj1.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj2.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj3.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj4.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj5.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj6.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj7.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj8.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj9.jpg",
                "C:/Users/nico936d/Pictures/Camera Roll/nicolaj10.jpg"
            };

        public bool auto = true;

        public MainWindow()
        {
            InitializeComponent();
            Wait();
            
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] userNames =
            {
                "Ole",
                "MinHundErSød"
            };
            string[] passwords =
            {
                "Brian",
                "Lastbil2006$Rød"
            };
            for (int i = 0; i < userNames.Length; i++)
            {
                if(usernameInput.Text == userNames[i] && passwordInput.Password == passwords[i])
                {
                    MessageBox.Show($"Du er nu logget ind under {userNames[i]}");
                }
                else
                {
                    MessageBox.Show("Desværre enten er brugernavn eller adgangskoden forkert prøv igen.");
                }
            }
        }

        public void changeImg()
        {
            
            if (i == imageSources.Length)
            {
                i = 0;
            }
            bgImg.Source = new BitmapImage(new Uri($@"{imageSources[i]}"));
        }
        private async void Wait()
        {
            await Task.Delay(2000);
            i++;
            if(auto == true)
            {
                changeImg();
            }
            else
            {
                auto = true;
            }

            Wait();
        }

        private void imgBackBtn_Click(object sender, RoutedEventArgs e)
        {
            auto = false;
            if (i == 0)
            {
                i = imageSources.Length;
                changeImg();
            }
            else
            {
                i--;
                changeImg();
            }
        }

        private void imgForwarBtn_Click(object sender, RoutedEventArgs e)
        {
            auto = false;
            i++;
            changeImg();
        }

        private void maby(object sender, RoutedEventArgs e)
        {
            checkedText.Text = "Maby!";
        }

        private void isChecked(object sender, RoutedEventArgs e)
        {
            checkedText.Text = "Checked!";
        }

        private void unChecked(object sender, RoutedEventArgs e)
        {
            checkedText.Text = "Is not checked!";
        }

        private void greenBackground(object sender, RoutedEventArgs e)
        {
            canvas1.Background = Brushes.LightGreen;
            bgImg.Visibility = Visibility.Hidden;
        }

        private void yellowBackground(object sender, RoutedEventArgs e)
        {
            canvas1.Background = Brushes.Yellow;
            bgImg.Visibility = Visibility.Hidden;
        }

        private void redBackground(object sender, RoutedEventArgs e)
        {
            canvas1.Background = Brushes.Red;
            bgImg.Visibility = Visibility.Hidden;
        }

        private void hideColorBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void inactiveColorBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void akitiveColorBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
