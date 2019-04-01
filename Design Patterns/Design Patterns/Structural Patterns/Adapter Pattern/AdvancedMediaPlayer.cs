using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter
{
    public interface AdvancedMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);
    }
}
