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
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/itrep.png");
            image.EndInit();
            ITRespect.image.Source = image;
        }

        private void LegalRespect_Loaded(object sender, RoutedEventArgs e)
        {
            LegalRespect.TitleText = "Правовая репутация";
            LegalRespect.ContentBlock = "Карма: 0 \nСтатус: Гражданин";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/LegalRep.png");
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
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Satiety.png");
            image.EndInit();
            Satiety.image.Source = image;
        }

        private void Mood_Loaded(object sender, RoutedEventArgs e)
        {
            Mood.TitleText = "Настроение";
            Mood.Progress = 75;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Mood.png");
            image.EndInit();
            Mood.image.Source = image;
        }

        private void Health_Loaded(object sender, RoutedEventArgs e)
        {
            Health.TitleText = "Здоровье";
            Health.Progress = 100;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Health.png");
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
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Work.png");
            image.EndInit();
            MainJob.image.Source = image;
        }

        private void ExtraWork_Loaded(object sender, RoutedEventArgs e)
        {
            ExtraWork.TitleText = "Подработка";
            ExtraWork.ContentBlock = "Дополнительный заработок";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/ExtraWork.png");
            image.EndInit();
            ExtraWork.image.Source = image;
        }

        private void Bank_Loaded(object sender, RoutedEventArgs e)
        {
            Bank.TitleText = "Банк";
            Bank.ContentBlock = "На вашем счету: 0 р. \nВаша задолженность: 0 р.";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Bank.png");
            image.EndInit();
            Bank.image.Source = image;
        }

        private void House_Loaded(object sender, RoutedEventArgs e)
        {
            House.TitleText = "Недвижимость";
            House.ContentBlock = "Нет недвижимости";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/House.png");
            image.EndInit();
            House.image.Source = image;
        }

        private void Transport_Loaded(object sender, RoutedEventArgs e)
        {
            Transport.TitleText = "Транспорт";
            Transport.ContentBlock = "Нет транспорта";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Transport.png");
            image.EndInit();
            Transport.image.Source = image;
        }

        private void Business_Loaded(object sender, RoutedEventArgs e)
        {
            Business.TitleText = "Бизнес";
            Business.ContentBlock = "Нет источника доходов";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Business.png");
            image.EndInit();
            Business.image.Source = image;
        }

        private void StockExchange_Loaded(object sender, RoutedEventArgs e)
        {
            StockExchange.TitleText = "Фондовая биржа";
            StockExchange.ContentBlock = "Капитализация корпораций";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/StockExchange.png");
            image.EndInit();
            StockExchange.image.Source = image;
        }

        private void PCSysUnit_Loaded(object sender, RoutedEventArgs e)
        {
            PCSysUnit.TitleText = "Системный блок";
            PCSysUnit.ContentBlock = "Системный блок с Intel Pentium II";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/CPU.png");
            image.EndInit();
            PCSysUnit.image.Source = image;
        }

        private void PCRAM_Loaded(object sender, RoutedEventArgs e)
        {
            PCRAM.TitleText = "Оперативная память";
            PCRAM.ContentBlock = "DRAM 32 Mb";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/DRAM.png");
            image.EndInit();
            PCRAM.image.Source = image;
        }

        private void PCHDD_Loaded(object sender, RoutedEventArgs e)
        {
            PCHDD.TitleText = "Жесткий диск";
            PCHDD.ContentBlock = "HDD 20 GB";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/HDD.png");
            image.EndInit();
            PCHDD.image.Source = image;
        }

        private void PCVideoCard_Loaded(object sender, RoutedEventArgs e)
        {
            PCVideoCard.TitleText = "Видеокарта";
            PCVideoCard.ContentBlock = "GeForce 256";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/GPU.png");
            image.EndInit();
            PCVideoCard.image.Source = image;
        }

        private void PCMonitor_Loaded(object sender, RoutedEventArgs e)
        {
            PCMonitor.TitleText = "Монитор";
            PCMonitor.ContentBlock = "15 \", CRT";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/LCD.png");
            image.EndInit();
            PCMonitor.image.Source = image;
        }

        private void PCNetwork_Loaded(object sender, RoutedEventArgs e)
        {
            PCNetwork.TitleText = "Сеть";
            PCNetwork.ContentBlock = "dial-UP 56 kbit/s";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/Ethernet.png");
            image.EndInit();
            PCNetwork.image.Source = image;
        }

        private void OS_Loaded(object sender, RoutedEventArgs e)
        {
            OS.TitleText = "Операционная система";
            OS.ContentBlock = "Windows 95";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/OS.png");
            image.EndInit();
            OS.image.Source = image;
        }

        private void AntiVirus_Loaded(object sender, RoutedEventArgs e)
        {
            AntiVirus.TitleText = "Антивирус";
            AntiVirus.ContentBlock = "Stop!";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/AntiVirus.png");
            image.EndInit();
            AntiVirus.image.Source = image;
        }

        private void IDE_Loaded(object sender, RoutedEventArgs e)
        {
            IDE.TitleText = "Разработка";
            IDE.ContentBlock = "Нет";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/IDE.png");
            image.EndInit();
            IDE.image.Source = image;
        }

        private void Games_Loaded(object sender, RoutedEventArgs e)
        {
            Games.TitleText = "Игры";
            Games.ContentBlock = "Нет";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/Games.png");
            image.EndInit();
            Games.image.Source = image;
        }
    }
}
