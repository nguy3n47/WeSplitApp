using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WeSplit
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Trip.Children.Clear();
            Trip.Children.Add(new Home());
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Menu.Width.ToString().Equals("60"))
            {
                Menu.Width = 240;
            }
            else
            {
                Menu.Width = 60;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (0 + (60 * index)), 0, 0);
        }

        private void itemMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int index = itemMenu.SelectedIndex;
            if (index != 0)
            {
                MoveCursorMenu(index);
            }
            switch (index)
            {
                case 1:
                    NewTrips t = new NewTrips();
                    t.Show();
                    this.Close();
                    break;
                case 2:
                    Trip.Children.Clear();
                    Trip.Children.Add(new Home());
                    break;
                case 3:
                    Trip.Children.Clear();
                    Trip.Children.Add(new Finish());
                    break;
                case 4:
                    Trip.Children.Clear();
                    Trip.Children.Add(new Notebook());
                    break;
                case 5:
                    Trip.Children.Clear();
                    Trip.Children.Add(new About());
                    break;
                case 6:
                    Trip.Children.Clear();
                    Trip.Children.Add(new Help());
                    break;
                case 7:
                    Trip.Children.Clear();
                    Trip.Children.Add(new Setting());
                    break;
                default:
                    break;
            }
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            NewTrips t = new NewTrips();
            t.Show();
            this.Close();
        }
    }
}