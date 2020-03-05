using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    public interface IStreamingDevice
    {
        //  prop+tab+tab
        public string DeviceName { get; set; }  
        public bool IsPlaying { get; set; }    
        public bool IsPaused { get; set; }
        //methods
        bool Play();    
        void Pause();  
        void Ffwd();    
        void Rewind();
        bool Stop();
    }
    class MediaPlayer
    {
    }
    public class DVDPlayer : IStreamingDevice
    {
        public DVDPlayer()
        {
            DeviceName = "My DVD Player";
            IsPlaying = false;
            IsPaused = false;
        }
        public string DeviceName { get; set; }

        public bool IsPlaying { get; set; }
        public bool IsPaused { get; set; }

        public void Ffwd()
        {
            Console.WriteLine($"\nFfwd {DeviceName}");

        }
        public void Pause()
        {
            //throw new NotImplementedException();
            if (IsPlaying)
            {
                IsPaused = true;
                Console.WriteLine($"\n{DeviceName} paused.");
            }
            else Console.WriteLine($"\nCan't pause. {DeviceName} is not playing.");
        }
        public bool Play()
        {
            Console.WriteLine($"\nPlaying {DeviceName}");
            IsPlaying = true;
            IsPaused = false;
            return IsPlaying;
        }
        public void Rewind()
        {
            Console.WriteLine($"\nRewind {DeviceName}");
        }
        public bool Stop()
        {
            Console.WriteLine($"\n{DeviceName} is now stopped.");
            IsPlaying = false;
            return IsPlaying;
        }
    }
}