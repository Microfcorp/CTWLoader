using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CTW_loader.Theme
{
    class MusicsControls
    {
        private BackgroundWorker Th = new BackgroundWorker();
        public Music ms
        {
            get;
            private set;
        }
        public MusicsControls()
        {
            Th.WorkerSupportsCancellation = true;
        }
        public void SetMusic(Music ms)
        {
            this.ms = ms;
        }
        public void Play()
        {
            Th = new BackgroundWorker();
            Th.WorkerSupportsCancellation = true;
            Th.DoWork += ms.PlayMusic;
            Th.RunWorkerAsync();
            Thread.Sleep(100);
        }
        public void Stop()
        {
            Th.CancelAsync();
            Thread.Sleep(400);
        }
        public static Music RandomMusic(params Music[] ms)
        {
            Random rnd = new Random();
            return ms[rnd.Next(0, ms.Length)];
        }
    }
}
