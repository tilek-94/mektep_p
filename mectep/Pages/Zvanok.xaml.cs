using System;
using mectep.All_class;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace mectep.Pages
{
    /// <summary>
    /// Логика взаимодействия для Zvanok.xaml
    /// </summary>
    public partial class Zvanok : Page
    {
        public Zvanok()
        {
            InitializeComponent();

        }

        Music zvonok = new Music();
        MainWindow close = new MainWindow();
        bool check = true, cc = false;
        ToggleButton c = null;



        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {

            if (c == null) { c = sender as ToggleButton; }
            zvonok.del_ += mess => check = mess;

            if (c != sender as ToggleButton) { c.IsChecked = check; }
            c = sender as ToggleButton;

            zvonok.Sound(sender as ToggleButton);
        }



    }
}
