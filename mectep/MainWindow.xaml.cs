﻿using System;
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
using System.Windows.Threading;

namespace mectep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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


            Date.Text = DateTime.Now.ToLongDateString();

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
            FramePage.Navigate(new Uri("Pages/Camera.xaml", UriKind.Relative));
            Schet = 1;
            Togl();
        }
        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            FramePage.Navigate(new Uri("Pages/Zvanok.xaml", UriKind.Relative));
            Schet = 2;
            Togl();
        }
        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            Schet = 3;
            Togl();
        }
        private void MenuButton4_Click(object sender, RoutedEventArgs e)
        {
            Schet = 4;
            Togl();
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
        void timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Open_Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Menu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}







