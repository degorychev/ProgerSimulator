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
            UpdateAll();
        }
        player Player = new player("Вася");

        private void UpdateAll()
        {
            ITRespect.ContentBlock = Player.getItRep();
            LegalRespect.ContentBlock = Player.getLegalRep();
            Money.ContentBlock = Player.getMoney();
            Satiety.Progress = Player.Satiety;
            Mood.Progress = Player.Mood;
            Health.Progress = Player.Health;
            MainJob.ContentBlock = Player.MainJob.ToStringToBlock();
        }

        private void ITRespect_Loaded(object sender, RoutedEventArgs e)
        {
            ITRespect.TitleText = "IT репутация";
            //ITRespect.ContentBlock = Player.getItRep();
            ITRespect.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/itrep.png"));
        }

        private void LegalRespect_Loaded(object sender, RoutedEventArgs e)
        {
            LegalRespect.TitleText = "Правовая репутация";
            //LegalRespect.ContentBlock = "Карма: 0 \nСтатус: Гражданин";
            LegalRespect.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/LegalRep.png"));
        }

        private void Money_Loaded(object sender, RoutedEventArgs e)
        {
            Money.TitleText = "Деньги";
            //Money.ContentBlock = "1000 р.";
        }

        private void Satiety_Loaded(object sender, RoutedEventArgs e)
        {
            Satiety.TitleText = "Сытость";
            //Satiety.Progress = 70;
            Satiety.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Satiety.png"));
        }

        private void Mood_Loaded(object sender, RoutedEventArgs e)
        {
            Mood.TitleText = "Настроение";
            //Mood.Progress = 75;
            Mood.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Mood.png"));
        }

        private void Health_Loaded(object sender, RoutedEventArgs e)
        {
            Health.TitleText = "Здоровье";
            //Health.Progress = 100;
            Health.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Main/Health.png"));
        }

        private void DateNow_Loaded(object sender, RoutedEventArgs e)
        {
            DateNow.TitleText = "Дата";
            DateNow.ContentBlock = DateTime.Now.ToShortDateString();
        }

        private void MainJob_Loaded(object sender, RoutedEventArgs e)
        {
            MainJob.TitleText = "Работа";
            //MainJob.ContentBlock = "Безработный \nЗП: 0 р.";
            MainJob.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Work.png"));
        }

        private void ExtraWork_Loaded(object sender, RoutedEventArgs e)
        {
            ExtraWork.TitleText = "Подработка";
            ExtraWork.ContentBlock = "Дополнительный заработок";
            ExtraWork.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/ExtraWork.png"));
        }

        private void Bank_Loaded(object sender, RoutedEventArgs e)
        {
            Bank.TitleText = "Банк";
            Bank.ContentBlock = "На вашем счету: 0 р. \nВаша задолженность: 0 р.";
            Bank.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Bank.png"));
        }

        private void House_Loaded(object sender, RoutedEventArgs e)
        {
            House.TitleText = "Недвижимость";
            House.ContentBlock = "Нет недвижимости";
            House.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/House.png"));
        }

        private void Transport_Loaded(object sender, RoutedEventArgs e)
        {
            Transport.TitleText = "Транспорт";
            Transport.ContentBlock = "Нет транспорта";
            Transport.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Transport.png"));
        }

        private void Business_Loaded(object sender, RoutedEventArgs e)
        {
            Business.TitleText = "Бизнес";
            Business.ContentBlock = "Нет источника доходов";
            Business.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/Business.png"));
        }

        private void StockExchange_Loaded(object sender, RoutedEventArgs e)
        {
            StockExchange.TitleText = "Фондовая биржа";
            StockExchange.ContentBlock = "Капитализация корпораций";
            StockExchange.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Work/StockExchange.png"));
        }

        private void PCSysUnit_Loaded(object sender, RoutedEventArgs e)
        {
            PCSysUnit.TitleText = "Системный блок";
            PCSysUnit.ContentBlock = "Системный блок с Intel Pentium II";
            PCSysUnit.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/CPU.png"));
        }

        private void PCRAM_Loaded(object sender, RoutedEventArgs e)
        {
            PCRAM.TitleText = "Оперативная память";
            PCRAM.ContentBlock = "DRAM 32 Mb";
            PCRAM.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/DRAM.png"));
        }

        private void PCHDD_Loaded(object sender, RoutedEventArgs e)
        {
            PCHDD.TitleText = "Жесткий диск";
            PCHDD.ContentBlock = "HDD 20 GB";
            PCHDD.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/HDD.png"));
        }

        private void PCVideoCard_Loaded(object sender, RoutedEventArgs e)
        {
            PCVideoCard.TitleText = "Видеокарта";
            PCVideoCard.ContentBlock = "GeForce 256";
            PCVideoCard.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/GPU.png"));
        }

        private void PCMonitor_Loaded(object sender, RoutedEventArgs e)
        {
            PCMonitor.TitleText = "Монитор";
            PCMonitor.ContentBlock = "15 \", CRT";
            PCMonitor.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/LCD.png"));
        }

        private void PCNetwork_Loaded(object sender, RoutedEventArgs e)
        {
            PCNetwork.TitleText = "Сеть";
            PCNetwork.ContentBlock = "dial-UP 56 kbit/s";
            PCNetwork.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/PC/Ethernet.png"));
        }

        private void OS_Loaded(object sender, RoutedEventArgs e)
        {
            OS.TitleText = "Операционная система";
            OS.ContentBlock = "Windows 95";
            OS.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/OS.png"));
        }

        private void AntiVirus_Loaded(object sender, RoutedEventArgs e)
        {
            AntiVirus.TitleText = "Антивирус";
            AntiVirus.ContentBlock = "Stop!";
            AntiVirus.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/AntiVirus.png"));
        }

        private void IDE_Loaded(object sender, RoutedEventArgs e)
        {
            IDE.TitleText = "Разработка";
            IDE.ContentBlock = "Нет";
            IDE.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/IDE.png"));
        }

        private void Games_Loaded(object sender, RoutedEventArgs e)
        {
            Games.TitleText = "Игры";
            Games.ContentBlock = "Нет";
            Games.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Software/Games.png"));
        }

        private void Education_Loaded(object sender, RoutedEventArgs e)
        {
            Education.TitleText = "Образование";
            Education.ContentBlock = "Нет образования";
            Education.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Education/Education.png"));
        }

        private void Courses_Loaded(object sender, RoutedEventArgs e)
        {

            Courses.TitleText = "Курсы";
            Courses.ContentBlock = "Не пройдено курсов";
            Courses.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Education/Courses.png"));
        }

        private void Books_Loaded(object sender, RoutedEventArgs e)
        {

            Books.TitleText = "Книги";
            Books.ContentBlock = "Не прочтено книг";
            Books.image.Source = ImageLoad(new Uri("pack://application:,,,/ProgerSimulator;component/Images/Education/Books.png"));
        }

        public static BitmapImage ImageLoad(Uri path)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = path;
            image.EndInit();
            return image;
        }

        private void MainJob_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ViewList listJob = new ViewList("Список вакансий", Job.GetJobsList(), Player.getSkills());
            listJob.ShowDialog();
            if (listJob.isok)
                Player.MainJob = listJob.selected;
            UpdateAll();
        }
    }
}
