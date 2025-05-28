using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.ProxyExample
{
    public class RealVideo : IVideo
    {
        private string fileName;

        public RealVideo(string fileName)
        {
            this.fileName = fileName;
            LoadVideoFromDisk(); //hard operation
        }

        private void LoadVideoFromDisk()
        {
            Console.WriteLine("Video is loading from disk: " + fileName);
        }

        public void Play()
        {
            Console.WriteLine("Video is playing: " + fileName);
        }
    }
}
