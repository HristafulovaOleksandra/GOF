using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.FacadeExample
{
    public class HomeTheaterFacade
    {
        private TV tv;
        private AudioSystem audio;
        private Lights lights;
        private DVDPlayer dvd;

        public HomeTheaterFacade(TV tv, AudioSystem audio, Lights lights, DVDPlayer dvd)
        {
            this.tv = tv;
            this.audio = audio;
            this.lights = lights;
            this.dvd = dvd;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            tv.On();
            audio.On();
            lights.Dim();
            dvd.Play();
        }
    }

}
