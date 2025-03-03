
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    interface IPlayable
    {
        public void Play();
    }
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("This is a video player class");
        }
    }
    class MusicPlayer: IPlayable
    {
        public void Play()
        {
            Console.WriteLine("This is a music player class");
        }
    }
}
