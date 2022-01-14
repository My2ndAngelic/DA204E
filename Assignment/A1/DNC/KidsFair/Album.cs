using System;

namespace A1
{
    public class Album
    {
        /// Album name, artist name, and number of tracks
        private string albumName; 
        private string artistName; 
        private int numOfTracks; 

        /// <summary>
		/// 
		/// </summary>
        public void Start()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
            ReadAndSaveAlbum();
            Console.WriteLine();
            DisplayAlbumInfo();
            Console.WriteLine();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveAlbum()
        {
            ReadAndSaveAlbumName();
            ReadAndSaveArtistName();
            ReadAndSaveNumOfTracks();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }

        /// <summary>
		///
		/// </summary>
        public void ReadAndSaveArtistName()
        {
            Console.WriteLine("What is the name of the Artist or Band for ", albumName, "?");
            artistName = Console.ReadLine();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveNumOfTracks()
        {
            Console.WriteLine("How many tracks does ", albumName, " have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        /// <summary>
		/// 
		/// </summary>
        public void DisplayAlbumInfo()
        {
            Console.WriteLine("Album name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of tracks: " + numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }
    }
}
