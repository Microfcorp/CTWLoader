using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CTW_loader.Theme.Musics
{
    class Mario : Music
    {
        System.ComponentModel.BackgroundWorker bw;
        public override void PlayMusic(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bw = (System.ComponentModel.BackgroundWorker)sender;
            try
            {
                while (!bw.CancellationPending)
                    MarioPlay(); if (bw.CancellationPending) return;
            }
            catch
            {
                return;
            }
        }

        private void MarioPlay()
        {
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Thread.Sleep(375); if (bw.CancellationPending) return;
            Console.Beep(392, 125); if (bw.CancellationPending) return;
            Thread.Sleep(375); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(392, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(330, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(494, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(466, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(392, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(880, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Console.Beep(494, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(392, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(330, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(494, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(466, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(392, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(880, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Console.Beep(494, 125); if (bw.CancellationPending) return;
            Thread.Sleep(375); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(415, 125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(625); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(415, 125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(1125); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(415, 125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(625); if (bw.CancellationPending) return;
            Console.Beep(784, 125); if (bw.CancellationPending) return;
            Console.Beep(740, 125); if (bw.CancellationPending) return;
            Console.Beep(698, 125); if (bw.CancellationPending) return;
            Thread.Sleep(42); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(659, 125); if (bw.CancellationPending) return;
            Thread.Sleep(167); if (bw.CancellationPending) return;
            Console.Beep(415, 125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Thread.Sleep(125); if (bw.CancellationPending) return;
            Console.Beep(440, 125); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(622, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(587, 125); if (bw.CancellationPending) return;
            Thread.Sleep(250); if (bw.CancellationPending) return;
            Console.Beep(523, 125); if (bw.CancellationPending) return;

        }

    }
}
