using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    class AudioPlayer : IMediaPlayer
    {
        MediaAdapter m_mediaAdapter;
        public void Play(AudioType audioType, string fileName)
        {
            switch (audioType)
            {
                case AudioType.Mp3:
                    Console.WriteLine("Playing Mp3 file.FileName = " + fileName);
                    break;
                case AudioType.Vlc:
                case AudioType.Mp4:
                case AudioType.Avi:
                    m_mediaAdapter = new MediaAdapter(audioType);
                    m_mediaAdapter.Play(audioType, fileName);
                    break;
            }
        }
    }
}
