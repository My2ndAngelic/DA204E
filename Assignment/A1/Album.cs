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
            ReadAndSaveAlbum();
            DisplayAlbumInfo();
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

        }
    }
}
