using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CTW_loader.Theme.Musics
{
    class Elize : Music
    {
        System.ComponentModel.BackgroundWorker bw;
        public override void PlayMusic(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bw = (System.ComponentModel.BackgroundWorker)sender;
            try
            {
                while (!bw.CancellationPending)
                    KElize(); if (bw.CancellationPending) return;
            }
            catch
            {
                return;
            }
        }

        private void KElize()
        {
            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(622, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(622, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(587, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(523, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(440, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(262, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(330, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(440, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(330, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(415, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(523, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(330, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(622, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(622, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(659, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(587, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(523, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(440, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(262, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(330, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(440, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;

            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(330, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(523, 120); if (bw.CancellationPending) return;
            Thread.Sleep(130); if (bw.CancellationPending) return;
            Console.Beep(494, 120); if (bw.CancellationPending) return;
            Thread.Sleep(150); if (bw.CancellationPending) return;
            Console.Beep(440, 120); if (bw.CancellationPending) return;
        }
    }
}
