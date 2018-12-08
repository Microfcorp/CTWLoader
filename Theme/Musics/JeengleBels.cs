using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CTW_loader.Theme.Musics
{
    class JeengleBels : Music
    {
        System.ComponentModel.BackgroundWorker bw;
        public override void PlayMusic(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bw = (System.ComponentModel.BackgroundWorker)sender;
            try
            {
                while (!bw.CancellationPending)
                {
                    refrenSolo(); if (bw.CancellationPending) return;
                    coupleSolo(); if (bw.CancellationPending) return;
                    refrenSolo(); if (bw.CancellationPending) return;
                }
            }
            catch
            {
                return;
            }
        }

        private void refrenSolo()
        {
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(261, 300); if (bw.CancellationPending) return;
            Console.Beep(293, 300); if (bw.CancellationPending) return;
            Console.Beep(329, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(261, 300); if (bw.CancellationPending) return;
            Console.Beep(293, 300); if (bw.CancellationPending) return;
            Console.Beep(329, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Thread.Sleep(300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
        }
        private void coupleSolo()
        {
            Console.Beep(392, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(392, 600); if (bw.CancellationPending) return;
            Thread.Sleep(300 * 2); if (bw.CancellationPending) return;
            Console.Beep(392, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(440, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(440, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(880, 300); if (bw.CancellationPending) return;
            Console.Beep(880, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(622, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(392, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(392, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(392, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 300); if (bw.CancellationPending) return;
            Console.Beep(440, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(440, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(659, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
            Console.Beep(880, 300); if (bw.CancellationPending) return;
            Console.Beep(783, 300); if (bw.CancellationPending) return;
            Console.Beep(698, 300); if (bw.CancellationPending) return;
            Console.Beep(587, 300); if (bw.CancellationPending) return;
            Console.Beep(523, 600); if (bw.CancellationPending) return;
            Thread.Sleep(600); if (bw.CancellationPending) return;
        }
    }
}
