using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter
{
    public interface MediaPlayer
    {
        void play(string audioType, string fileName);
    }
}
