// See https://aka.ms/new-console-template for more information
using TP_MODUL6_103022400074;

class Program 
{ 
    static void Main(string[] args) 
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Sayamusictrack");

        track1.IncreasePlayCount(10);
        track1.IncreasePlayCount(5);
        track1.PrintTrackDetails();
        Console.ReadLine();
    }
}
