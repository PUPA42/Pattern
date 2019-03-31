using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer m_advancedMediaPlayer;
        public MediaAdapter(AudioType audioType)
        {
            switch (audioType)
            {
                case AudioType.Vlc:
                    m_advancedMediaPlayer = new VlcPlayer();
                    break;
                case AudioType.Mp4:
                    m_advancedMediaPlayer = new Mp4Player();
                    break;
                case AudioType.Avi:
                    m_advancedMediaPlayer = null;
                    break;
            }
        }

        public void Play(AudioType audioType, string fileName)
        {
            switch (audioType)
            {
                case AudioType.Vlc:
                    m_advancedMediaPlayer.PlayVlc(fileName);
                    break;
                case AudioType.Mp4:
                    m_advancedMediaPlayer.PlayMp4(fileName);
                    break;
                case AudioType.Avi:
                    Console.WriteLine("The format is invalid.");
                    break;
            }
        }
    }
}
