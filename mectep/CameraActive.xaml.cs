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
using System.Windows.Shapes;

namespace mectep
{
    /// <summary>
    /// Логика взаимодействия для CameraActive.xaml
    /// </summary>
    public partial class CameraActive : Window
    {
        public CameraActive()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Camera.Stop();
            
         
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Camera.Source=new Uri("E:\\klip\\12345.mp4");
            Camera.Play();
        }
    }
}
