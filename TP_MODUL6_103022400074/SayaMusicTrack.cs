using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400074
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;


        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random rand = new Random();
            this.id = rand.Next(1000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Play Count   : " + playCount);
        }

    }
}
