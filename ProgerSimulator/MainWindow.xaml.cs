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

namespace ProgerSimulator
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

        private void ITRespect_Loaded(object sender, RoutedEventArgs e)
        {
            ITRespect.TitleText = "IT репутация";
            ITRespect.ContentBlock = "Опыт: 0 \nСтатус: Ламер";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/itrep.png");
            image.EndInit();
            ITRespect.image.Source = image;
        }

        private void LegalRespect_Loaded(object sender, RoutedEventArgs e)
        {
            LegalRespect.TitleText = "Правовая репутация";
            LegalRespect.ContentBlock = "Карма: 0 \nСтатус: Гражданин";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/LegalRep.png");
            image.EndInit();
            LegalRespect.image.Source = image;
        }

        private void Money_Loaded(object sender, RoutedEventArgs e)
        {
            Money.TitleText = "Деньги";
            Money.ContentBlock = "1000 р.";
        }

        private void Satiety_Loaded(object sender, RoutedEventArgs e)
        {
            Satiety.TitleText = "Сытость";
            Satiety.Progress = 70;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Satiety.png");
            image.EndInit();
            Satiety.image.Source = image;
        }

        private void Mood_Loaded(object sender, RoutedEventArgs e)
        {
            Mood.TitleText = "Настроение";
            Mood.Progress = 75;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Mood.png");
            image.EndInit();
            Mood.image.Source = image;
        }

        private void Health_Loaded(object sender, RoutedEventArgs e)
        {
            Health.TitleText = "Здоровье";
            Health.Progress = 100;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Health.png");
            image.EndInit();
            Health.image.Source = image;
        }

        private void DateNow_Loaded(object sender, RoutedEventArgs e)
        {
            DateNow.TitleText = "Дата";
            DateNow.ContentBlock = DateTime.Now.ToShortDateString();
        }
    }
}
