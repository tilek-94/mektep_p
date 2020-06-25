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

namespace mectep.Pages
{
    /// <summary>
    /// Логика взаимодействия для Muzyka.xaml
    /// </summary>
    public partial class Muzyka : Page
    {
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        public Muzyka()
        {
            InitializeComponent();
        }
        //bot
        private void Muz_Button_Click(object sender, RoutedEventArgs e)
        {
            Window_Add_MRZ newwindow = new Window_Add_MRZ();
            newwindow.Owner = gk;
            newwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            newwindow.ShowDialog();
        }
    }
}
