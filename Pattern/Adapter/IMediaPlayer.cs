using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    enum AudioType
    {
        Mp3,
        Vlc,
        Mp4,
        Avi,
    }
    interface IMediaPlayer
    {
        void Play(AudioType audioType, string fileName);
    }
}
