using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TP_MODUL6_103022400074
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            
            Debug.Assert(title != null, "title tidak boleh null.");
            Debug.Assert(title.Length <= 100, "title maksimal 100 karakter.");

            this.title = title;
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            
            Debug.Assert(count <= 10000000, "penambahan play count maksimal 10.000.000.");
            Debug.Assert(count >= 0, "penambahan play count tidak boleh negatif");

            try
            {
                
                playCount = checked(playCount + count);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow terdeteksi pada track '{title}': {ex.Message}");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID     : " + id);
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Plays  : " + playCount);
            
        }
    }
}