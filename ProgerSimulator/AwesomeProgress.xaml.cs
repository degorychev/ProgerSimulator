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
    /// Логика взаимодействия для AwesomeButton.xaml
    /// </summary>
    public partial class AwesomeProgress : UserControl
    {
        public AwesomeProgress()
        {
            InitializeComponent();
        }
        public static DependencyProperty TitleProperty = DependencyProperty.Register("TitleText", typeof(string), typeof(AwesomeProgress));
        public static DependencyProperty ProgressProperty = DependencyProperty.Register("Progress", typeof(int), typeof(AwesomeProgress));
        public static DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(Image), typeof(AwesomeProgress));


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

        public int Progress
        {
            get
            {
                return (int)GetValue(ProgressProperty);
            }
            set
            {
                SetValue(ProgressProperty, value);
            }
        }

        public Image ImageSource
        {
            get
            {
                return (Image)GetValue(ImageProperty);
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }
    }

}
