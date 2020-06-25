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
using System.Windows.Controls.Primitives;
using mectep.All_class;

namespace mectep.Pages
{
    /// <summary>
    /// Логика взаимодействия для Camera.xaml
    /// </summary>
    public partial class Camera : Page
    {
        public int id_btn = 0;
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
        ToggleButton[] btn_name = new ToggleButton[20];
        Camera_class Camera_ = new Camera_class(15);
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton btnSender = sender as ToggleButton;
           
            string text = btnSender.Name.ToString().Substring(3);
            id_btn = Convert.ToInt32(text);
            btn_name[id_btn] = sender as ToggleButton;
            int numBerbtn= id_btn;
            if (ch_b.IsChecked == false)
            {
               
                for (int i = 1; i <= 15; i++)
                {
                    if (btn_name[i] != null && id_btn != i)
                    {
                        btn_name[i].IsChecked = false;
                        
                    }
                    
                }
                
                lb_1.Content= Camera_.cameraVK(numBerbtn);
               
            }
            else
            {
               
                    lb_1.Content = Camera_.cameraVK2(id_btn, true);
                
            }
            btnSender.IsChecked = true;

        }
        private void ch_b_Click(object sender, RoutedEventArgs e)
        {

            if (ch_b.IsChecked == false)
            {

                for (int a = 0; a < 15; a++)
                {
                    if (btn_name[a] != null)
                    {
                        btn_name[a].IsChecked = false;

                    }
                }
                Camera_.MassivNul();
            }
            else
            {
                for (int a = 0; a < 15; a++)
                {
                    if (btn_name[a] != null)
                    {
                        btn_name[a].IsChecked = false;

                    }
                }

                Camera_.MassivNul();

            }
        }

        private void ch_b_Click2(object sender, RoutedEventArgs e)
        {
            ToggleButton btnSender = sender as ToggleButton;
            string text = btnSender.Name.ToString().Substring(3);
            id_btn = Convert.ToInt32(text);
            btn_name[id_btn] = sender as ToggleButton;
            if (ch_b.IsChecked == false)
            {
                Camera_.MassivNul();
               lb_1.Content = Camera_.cameraVK2(id_btn,false);
            }
            else
            {
                lb_1.Content = Camera_.cameraVK2(id_btn, false);

            }
            

        }
    }
}

