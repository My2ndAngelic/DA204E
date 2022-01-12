using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Album
    {
        // Album name, artist name, and number of tracks
        private string albumName; 
        private string artistName; 
        private int numOfTracks; 

        public void Start()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
            ReadAndSaveAlbum();
            Console.WriteLine();
            DisplayAlbumInfo();
            Console.WriteLine();
        }

        public void ReadAndSaveAlbum()
        {
            ReadAndSaveAlbumName();
            ReadAndSaveArtistName();
            ReadAndSaveNumOfTracks();
        }

        public void ReadAndSaveAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }
        public void ReadAndSaveArtistName()
        {
            Console.WriteLine("What is the name of the Artist or Band for ", albumName, "?");
            artistName = Console.ReadLine();
        }
        public void ReadAndSaveNumOfTracks()
        {
            Console.WriteLine("How many tracks does ", albumName, " have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine("Album name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of tracks: " + numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }
    }
}
