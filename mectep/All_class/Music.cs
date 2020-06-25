using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Threading.Tasks;
using System.Threading;

namespace mectep.All_class
{
    class Music
    {
        public delegate void DelegateBtn(bool s);
        public event DelegateBtn del_;
        Data_base Ad_name = new Data_base();
        private NAudio.Wave.BlockAlignReductionStream stream = null;
       public static NAudio.Wave.DirectSoundOut output = null;
        ToggleButton btn_n;
        string name = "";
        public void Sound(ToggleButton btn)
        {

            Ad_name.Adres("select name from music where id=" + Convert.ToString(btn.Name.ToString()[4]));
            name = Ad_name.muzic_name;

            if (btn_n != btn)
            {
                if (output != null)
                {
                    output.Stop();
                    output.Dispose();
                }
                gg(name);
                output.Play();
                btn_n = btn;
                del_(false);
            }
            else if (btn_n == btn)
            {
                if (output != null)
                {
                    output.Stop();
                    stream.Dispose();
                    output.Dispose();
                    output = null;
                }
                else if (output == null)
                {
                    gg(name);
                    output.Play();                    
                }
            }

        }      
        private void gg(string name)
        {
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(@"C:\Program Files (x86)\Mektep\sound\" + name));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
        }
        public void off()
        {
            if(output!=null)
            output.Stop();
        }
    }
}
