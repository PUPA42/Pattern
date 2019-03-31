using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            //Do Nothing
        }
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing Vlc file.FileName = "+fileName);
        }
    }
}
