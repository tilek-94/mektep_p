using System;
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

namespace mectep.Pages
{
    /// <summary>
    /// Логика взаимодействия для Camera.xaml
    /// </summary>
    public partial class Camera : Page
    {
        public CameraActive cam = new CameraActive();
        public Camera()
        {
            InitializeComponent();
        }

        private void Camera_Jandyruu_Click(object sender, RoutedEventArgs e)
        {
            if (Camera_Jandyruu.IsChecked == true)
            {
                Camera_Message.Text = "Баарын өчүрүү";
            }
            else
            {
                Camera_Message.Text = "Баарын жандыруу";
            }
        }
        ToggleButton[] btn_name = new ToggleButton[15];

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton fgjk = sender as ToggleButton;
            //MessageBox.Show(fgjk.Name.ToString());
            string xxx = fgjk.Name.ToString();
            int id_b = 0;

            if (Convert.ToInt32(Convert.ToString(fgjk.Name.ToString()[3])) == 0)
            {
                id_b = Convert.ToInt32(Convert.ToString(fgjk.Name.ToString()[4]));
            }
            else
            {
                id_b =/*(Convert.ToInt32(Convert.ToString(fgjk.Name.ToString()[3])) *10)*/10 + Convert.ToInt32(Convert.ToString(fgjk.Name.ToString()[4]));
            }
            btn_name[id_b - 1] = sender as ToggleButton;
            if (ch_b.IsChecked == false)
            {

                for (int a = 0; a < 15; a++)
                {
                    if (btn_name[a] != null && btn_name[id_b-1] != btn_name[a])
                    {
                        btn_name[a].IsChecked = false;
                    }

                }
                for (int b = 0; b < 15; b++)
                {
                    if (btn_name[b] != null && btn_name[id_b] != btn_name[b])
                    {
                        
                        cam.Show();
                    }

                }
            }
        }

        private void ch_b_Click(object sender, RoutedEventArgs e)
        {
            if (ch_b.IsChecked == false)
            {
                for (int a = 0; a < 15; a++)
                {
                    if (btn_name[a] != null) { btn_name[a].IsChecked = false; }
                }
            }
            else { }
        }
    }
}
