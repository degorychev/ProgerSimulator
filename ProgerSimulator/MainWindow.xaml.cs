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

        private void MainJob_Loaded(object sender, RoutedEventArgs e)
        {
            MainJob.TitleText = "Работа";
            MainJob.ContentBlock = "Безработный \nЗП: 0 р.";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work.png");
            image.EndInit();
            MainJob.image.Source = image;
        }

        private void ExtraWork_Loaded(object sender, RoutedEventArgs e)
        {
            ExtraWork.TitleText = "Подработка";
            ExtraWork.ContentBlock = "Дополнительный заработок";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/ExtraWork.png");
            image.EndInit();
            ExtraWork.image.Source = image;
        }

        private void Bank_Loaded(object sender, RoutedEventArgs e)
        {
            Bank.TitleText = "Банк";
            Bank.ContentBlock = "На вашем счету: 0 р. \nВаша задолженность: 0 р.";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Bank.png");
            image.EndInit();
            Bank.image.Source = image;
        }

        private void House_Loaded(object sender, RoutedEventArgs e)
        {
            House.TitleText = "Недвижимость";
            House.ContentBlock = "Нет недвижимости";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/House.png");
            image.EndInit();
            House.image.Source = image;
        }

        private void Transport_Loaded(object sender, RoutedEventArgs e)
        {
            Transport.TitleText = "Транспорт";
            Transport.ContentBlock = "Нет транспорта";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Transport.png");
            image.EndInit();
            Transport.image.Source = image;
        }

        private void Business_Loaded(object sender, RoutedEventArgs e)
        {
            Business.TitleText = "Бизнес";
            Business.ContentBlock = "Нет источника доходов";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Business.png");
            image.EndInit();
            Business.image.Source = image;
        }

        private void StockExchange_Loaded(object sender, RoutedEventArgs e)
        {
            StockExchange.TitleText = "Фондовая биржа";
            StockExchange.ContentBlock = "Капитализация корпораций";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/StockExchange.png");
            image.EndInit();
            StockExchange.image.Source = image;
        }
    }
}
