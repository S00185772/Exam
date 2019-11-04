using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Song S1 = new Song("Midnight Blues","Johhny Saxe",2.15 ,Genre.Dance)  ;  
            Song S3 = new Song("Computer Screen", "Jake", 3.36, Genre.Pop);
            Song S4 = new Song("Skid Marks", "Running Tommy", 2.5, Genre.Other);
            Song S5 = new Song("When You See Me", "Dr K", 2.11, Genre.Rock);
            Song S2 = new Song("Curtain Call", "Johhny Saxe", 5.01, Genre.Pop);

            List<Song> Playlist = new List<Song>();
            Playlist.Add(S1);
            Playlist.Add(S2);
            Playlist.Add(S3);
            Playlist.Add(S4);
            Playlist.Add(S5);

            Display(Playlist);

            //Display(Playlist);

            //Playlist.Sort();

            //Display(Playlist);
            //Playlist.Random;
        }



        private static void Display(List<Song> songs)
        {

            Console.WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}", "Artist", "Song", "Duration", "Genre");

            //Loop through all players and display score

            foreach (Song song in songs)
            {
                Console.Write("{0,-25}{1,-25}{2,-25}{3,-25}\n", song.Artist,song.Title,song.Duration,song.genre1 );
            }
            Console.WriteLine();

        }
    }
}
