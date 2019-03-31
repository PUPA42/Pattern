using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file.FileName = " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            //Do nothing
        }
    }
}
