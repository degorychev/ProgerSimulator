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
    /// Логика взаимодействия для AwesomeBasicLabel.xaml
    /// </summary>
    public partial class AwesomeBasicLabel : UserControl
    {
        public AwesomeBasicLabel()
        {
            InitializeComponent();
        }

        public static DependencyProperty TitleProperty = DependencyProperty.Register("TitleText", typeof(string), typeof(AwesomeBasicLabel));
        public static DependencyProperty ContentBlockProperty = DependencyProperty.Register("ContentBlock", typeof(string), typeof(AwesomeBasicLabel));

        public string TitleText
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public string ContentBlock
        {
            get
            {
                return (string)GetValue(ContentBlockProperty);
            }
            set
            {
                SetValue(ContentBlockProperty, value);
            }
        }
    }
}
