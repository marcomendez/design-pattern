using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {

        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }

        public VlcPlayer()
        {

        }
    }
}
