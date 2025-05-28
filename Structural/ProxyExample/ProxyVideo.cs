using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.ProxyExample
{
    public class ProxyVideo : IVideo
    {
        private string fileName;
        private RealVideo realVideo;

        public ProxyVideo(string fileName)
        {
            this.fileName = fileName;
        }

        public void Play()
        {
            if (realVideo == null)
            {
                realVideo = new RealVideo(fileName); //only for needs
            }
            realVideo.Play();
        }
    }
}
