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
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;
        int schot = 1, q = 1;
        public Muzyka()
        {
            InitializeComponent();
        }
        public void Sound(string name)
        {
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(@"E:\music\" + name + ".mp3"));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();

        }
        public void Stop()
        {
            output.Stop();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("123");
        }

        private void ToggleButton_Click_1(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("1234");
        }


        private void ToggleButton_Click_2(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("123");
        }

        private void ToggleButton_Click_3(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("1234");
        }

        private void ToggleButton_Click_4(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("123");
        }

        private void ToggleButton_Click_5(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("1234");
        }

        private void ToggleButton_Click_6(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("123");
        }

        private void ToggleButton_Click_7(object sender, RoutedEventArgs e)
        {
            q = 1;
            Go("1234");
        }

      
        public void Go(string musicName)
        {
            if (schot == 1)
            {
                Sound(musicName);
                output.Play();
                schot--;
            }
            else if (schot == 0 && q != 1)
            {
                output.Stop();
                stream.Dispose();
                output.Dispose();
                Sound(musicName);
                output.Play();
                q = 0;

            }
            else if (q != 0)
            {
                output.Stop();
                stream.Dispose();
                output.Dispose();
                schot = 1;


            }
        }
    }
}
