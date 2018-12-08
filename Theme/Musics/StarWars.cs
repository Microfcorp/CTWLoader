using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CTW_loader.Theme.Musics
{
    class StarWars : Music
    {
        System.ComponentModel.BackgroundWorker bw;
        public override void PlayMusic(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bw = (System.ComponentModel.BackgroundWorker)sender;
            try
            {
                while (!bw.CancellationPending)
                    StarWors(); if (bw.CancellationPending) return;
            }
            catch
            {
                return;
            }
        }

        private void StarWors()
        {
            Console.Beep(300, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(300, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(300, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(250, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(350, 250); if (bw.CancellationPending) return;
            Console.Beep(300, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(250, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
            Console.Beep(350, 250); if (bw.CancellationPending) return;
            Console.Beep(300, 500); if (bw.CancellationPending) return;
            Thread.Sleep(50); if (bw.CancellationPending) return;
        }
    }
}
