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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Pr_7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    ///  Метод DoubleAnimation создаёт анимированние для кнопки
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = Proba.ActualWidth;
            buttonAnimation.To = 212;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1.5);
            Proba.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }

        private void Feather(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Я творил, творю и буду творить!", "Ура?",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Вы сотворили чудо!", "Красавчик!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            else 
            {
                MessageBox.Show("Вы ничего не сотворили.", "Очень жаль :(",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
        }

        private void Btn_close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
