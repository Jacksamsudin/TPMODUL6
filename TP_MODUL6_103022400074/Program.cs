// See https://aka.ms/new-console-template for more information
using TP_MODUL6_103022400074;

class Program 
{ 
    static void Main(string[] args) 
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Sayamusictrack");

        track1.IncreasePlayCount(5000000);
        track1.PrintTrackDetails();

        for (int i = 0; i < 300; i++)
        {
            track1.IncreasePlayCount(10000000);
        }

        track1.PrintTrackDetails();
    }
}
