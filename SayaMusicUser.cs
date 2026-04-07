using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Modul6_103022400139
{
    internal class SayaMusicUser
    {
        private int id;
        public string Username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string title)
        {

            Random rand = new Random();

            this.id = rand.Next(10000, 99999);
            this.Username = Username;
            this.uploadedTracks = new List<SayaMusicTrack>();
        }

        public void GetTotalPlayCount()
        {
        }

        public void AddTrack(SayaMusicTrack track)
        {

        }

        public void PrintAllTracks()
        {

        }
    }
}
