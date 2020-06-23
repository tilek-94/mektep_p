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

namespace mectep.Pages
{
    /// <summary>
    /// Логика взаимодействия для Camera.xaml
    /// </summary>
    public partial class Camera : Page
    {
        public CameraActive cam = new CameraActive();

        public int id_b = 0;
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
            string all = "";
            int[] y = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            ToggleButton fgjk = sender as ToggleButton;
            //MessageBox.Show(fgjk.Name.ToString());
            string xxx = fgjk.Name.ToString();


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

                lb_1.Content = "";
                for (int a = 0; a < 15; a++)
                {


                    if (btn_name[a] != null && btn_name[id_b - 1] != btn_name[a])
                    {
                        btn_name[a].IsChecked = false;

                        y[id_b - 1] = 1;

                    }
                    if (btn_name[0] != null)
                    {
                        if (btn_name[0].IsChecked == true)
                        {
                            y[0] = 1;
                        }
                    }
                   
                    all += Convert.ToString(y[a]);
                }
                lb_1.Content = all;
            }
            else
            {
               
                for (int r = 0; r < 15; r++)
                {
                     string[] sq = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                    if (btn_name[r] != null) 
                    {
                        sq[r] += "1";
                    }
                    else
                    {
                        sq[r] += "0";
                    }
                    
                     
                   
                    all+=sq[r];

                }
                lb_1.Content = all;
        
            }
            
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
            }
            else
            {
                

            }
        }
    }
}

