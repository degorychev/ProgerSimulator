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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgerSimulator
{
    /// <summary>
    /// Логика взаимодействия для ViewList.xaml
    /// </summary>
    public partial class ViewList : Window
    {
        List<Job> List;
        public ViewList(string TitleWindow, List<Job> inputList, Requirements PlayerSkill)
        {
            InitializeComponent();
            this.Title = TitleWindow;
            int i = 0;
            List = inputList;
            foreach (Job element in List)
            {
                AwesomeLabel toMainGrid = new AwesomeLabel() ;
                toMainGrid.ContentBlock = element.ToStringToBlock();
                toMainGrid.TitleText = "Вакансия";
                toMainGrid.Margin = new Thickness(0, i*55, 0, 0);
                toMainGrid.MouseUp += new MouseButtonEventHandler(this.Click);
                toMainGrid.id = i;
                toMainGrid.image.Source = MainWindow.ImageLoad(GetUri(element, PlayerSkill));
                MainGrid.Children.Add(toMainGrid);
                i++;
            }
        }

        private Uri GetUri(Job job, Requirements skill)
        {
            return new Uri("pack://application:,,,/ProgerSimulator;component/Images/Education/Books.png");
        }

        private void Click(object sender, MouseButtonEventArgs args)
        {
            int id = ((AwesomeLabel)sender).id;
            MessageBox.Show(List[id].ToStringToBlock());
        }
    }
}
