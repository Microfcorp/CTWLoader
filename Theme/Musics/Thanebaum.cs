using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CTW_loader.Theme.Musics
{
    class Thanebaum : Music
    {
        System.ComponentModel.BackgroundWorker bw;
        public override void PlayMusic(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bw = (System.ComponentModel.BackgroundWorker)sender;
            try
            {
                while(!bw.CancellationPending)
                    Tannenbaum(); if (bw.CancellationPending) return;
            }
            catch
            {
                return;
            }
        }

        private void Tannenbaum()
        {
            Console.Beep(247, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(370, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(329, 500); if (bw.CancellationPending) return;
            Console.Beep(247, 500); if (bw.CancellationPending) return;
            Console.Beep(247, 500); if (bw.CancellationPending) return;
            Console.Beep(247, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(370, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(497, 500); if (bw.CancellationPending) return;
            Thread.Sleep(500); if (bw.CancellationPending) return;
            Console.Beep(497, 500); if (bw.CancellationPending) return;
            Console.Beep(277, 500); if (bw.CancellationPending) return;
            Console.Beep(277, 500); if (bw.CancellationPending) return;
            Console.Beep(440, 500); if (bw.CancellationPending) return;
            Console.Beep(440, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(370, 500); if (bw.CancellationPending) return;
            Console.Beep(329, 500); if (bw.CancellationPending) return;
            Console.Beep(247, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(370, 500); if (bw.CancellationPending) return;
            Console.Beep(417, 500); if (bw.CancellationPending) return;
            Console.Beep(329, 500); if (bw.CancellationPending) return;
            Thread.Sleep(500); if (bw.CancellationPending) return;
        }
    }
}
