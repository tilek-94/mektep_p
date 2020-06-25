using mectep.All_class;
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

namespace mectep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindow Window_Orientation = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        Music music = new Music();
        int Schet = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            Date.Text = datetime.ToLongTimeString();
            Time.Text = datetime.ToLongDateString();
            //FramePage.Navigate(new Uri("Pages/Camera.xaml", UriKind.Relative));
            FramePage.NavigationService.Navigate(new Uri("Pages/Camera.xaml", UriKind.Relative));
        }

        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximized_Click(object sender, RoutedEventArgs e)
        {
            if (this.Width == 1100 && this.Height == 600)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;

            }
        }

        private void Video_Kozomol_Click(object sender, RoutedEventArgs e)
        {
            FramePage.NavigationService.Navigate(new Uri("Pages/Camera.xaml", UriKind.Relative));
            Schet = 1;
            Togl();
            music.off();
        }
        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            FramePage.NavigationService.Navigate(new Uri("Pages/Zvanok.xaml", UriKind.Relative));
            Schet = 2;
            Togl();
            music.off();
        }
        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            FramePage.Navigate(new Uri("Pages/Window_Ubakyt.xaml", UriKind.Relative));
            Schet = 3;
            Togl();
            music.off();
        }
        private void MenuButton4_Click(object sender, RoutedEventArgs e)
        {
            FramePage.Navigate(new Uri("Pages/Muzyka.xaml", UriKind.Relative));
            Schet = 4;
            Togl();
            music.off();
        }
        public void Togl()
        {
            if (Schet == 1)
            {
                Video_Kozomol.IsChecked = true;
            }
            else
            {
                Video_Kozomol.IsChecked = false;
            }
            if (Schet == 2)
            {
                MenuButton2.IsChecked = true;
            }
            else
            {
                MenuButton2.IsChecked = false;
            }
            if (Schet == 3)
            {
                MenuButton3.IsChecked = true;
            }
            else
            {
                MenuButton3.IsChecked = false;
            }
            if (Schet == 4)
            {
                MenuButton4.IsChecked = true;
            }
            else
            {
                MenuButton4.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show(clickedButton.Content.ToString());
        }

        private void Close_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close_Menu.Visibility = Visibility.Collapsed;
            Open_Menu.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Collapsed;
            textBlock1.Visibility = Visibility.Collapsed;
            textBlock2.Visibility = Visibility.Collapsed;
            textBlock3.Visibility = Visibility.Collapsed;
            grid.Width = 60;
            Menu_Stacpanel.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void Open_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close_Menu.Visibility = Visibility.Visible;
            Open_Menu.Visibility = Visibility.Collapsed;
            textBlock.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;
            grid.Width = 200;
            Menu_Stacpanel.HorizontalAlignment = HorizontalAlignment.Right;
        }


    }
}
