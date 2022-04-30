using System;

namespace KidsFair
{
    public class Album
    {
        /// <summary>
        ///     Private fields
        /// </summary>
        private string albumName;

        private string artistName;
        private int numOfTracks;

        /// <summary>
        ///     Main method of the album class
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
        ///     Album data handler
        /// </summary>
        private void ReadAndSaveAlbum()
        {
            ReadAndSaveAlbumName();
            ReadAndSaveArtistName();
            ReadAndSaveNumOfTracks();
        }

        /// <summary>
        ///     This method asks user album name and saves it to the field
        /// </summary>
        private void ReadAndSaveAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }

        /// <summary>
        ///     This method asks user artist/band and saves it to the field
        /// </summary>
        private void ReadAndSaveArtistName()
        {
            Console.WriteLine("What is the name of the Artist or Band for {0}?", albumName);
            artistName = Console.ReadLine();
        }

        /// <summary>
        ///     This method asks user number of track and saves it to the field
        /// </summary>
        private void ReadAndSaveNumOfTracks()
        {
            Console.WriteLine("How many tracks does {0} have?", albumName);
            numOfTracks = int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///     Display the album info to the user
        /// </summary>
        private void DisplayAlbumInfo()
        {
            Console.WriteLine("Album name: {0}", albumName);
            Console.WriteLine("Artist/Band: {0}", artistName);
            Console.WriteLine("Number of tracks: {0}", numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }
    }
}
