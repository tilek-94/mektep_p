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
    /// Логика взаимодействия для Camera.xaml
    /// </summary>
    public partial class Camera : Page
    {
        public Camera()
        {
            InitializeComponent();
        }

        private void Camera_Jandyruu_Click(object sender, RoutedEventArgs e)
        {
            if (Camera_Jandyruu.IsChecked==true)
            {
                Camera_Message.Text = "Баарын өчүрүү";
            }
            else
            {
                Camera_Message.Text = "Баарын жандыруу";
            }
        }
    }
}
