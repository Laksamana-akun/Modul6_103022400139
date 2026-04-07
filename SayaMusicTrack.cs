using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Modul6_103022400139
{
    internal class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            Contract.Requires(title.Length <= 200, "Title melebihi 200 kata");

            Random rand = new Random();

            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
