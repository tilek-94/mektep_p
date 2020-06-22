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

    public partial class Zvanok : Page
    {
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;
        int schot = 1, q = 1;
        public Zvanok()
        {
            InitializeComponent();
        }
    
  

    public void Sound(string name)
    {
        NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(@"E:\music\" + name + ".mp3"));
        stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
        output = new NAudio.Wave.DirectSoundOut();
        output.Init(stream);

    }
    public void Stop()
    {
        output.Stop();
    }

        private void tb_1_Click(object sender, RoutedEventArgs e)
        {
            if (tb_1.IsChecked == true)
            {
                Sound("123");

            } else { Stop(); }
        }

        private void tb_2_Click(object sender, RoutedEventArgs e)
        {
            if (tb_2.IsChecked == true)
            {
                Sound("1234");

            }
            else { Stop(); }
        }

        private void tb_3_Click(object sender, RoutedEventArgs e)
        {
            if (tb_3.IsChecked == true)
            {
                Sound("123");

            }
            else { Stop(); }
        }

        private void tb_4_Click(object sender, RoutedEventArgs e)
        {
            if (tb_4.IsChecked == true)
            {
                Sound("1234");

            }
            else { Stop(); }
        }

        private void tb_5_Click(object sender, RoutedEventArgs e)
        {
            if (tb_5.IsChecked == true)
            {
                Sound("123");

            }
            else { Stop(); }
        }

        private void tb_6_Click(object sender, RoutedEventArgs e)
        {
            if (tb_6.IsChecked == true)
            {
                Sound("1234");

            }
            else { Stop(); }
        }

        private void tb_7_Click(object sender, RoutedEventArgs e)
        {
            if (tb_7.IsChecked == true)
            {
                Sound("123");

            }
            else { Stop(); }
        }

        private void tb_8_Click(object sender, RoutedEventArgs e)
        {
            if (tb_8.IsChecked == true)
            {
                Sound("1234");

            }
            else { Stop(); }
        }

       
        
    }
}

