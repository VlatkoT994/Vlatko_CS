using System;
using System.Collections.Generic;
using System.Text;

namespace Modles
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public Genre FavoriteMusicType;
        public List<Song> FavoriteSongs;


        public Person(string firstName, string lastName, int age, Genre favorite)
        {
            var rand = new Random();
            Id = rand.Next(1000);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favorite;
            FavoriteSongs = new List<Song>();
        }
        public void AddToFavorites(Song newSong)
        {
            FavoriteSongs.Add(newSong);
        }
        public void AddToFavorites(List<Song> newSongs)
        {
            newSongs.ForEach(song => { FavoriteSongs.Add(song); });
        }
        public void GetFavSongs()
        {
            if (FavoriteSongs.Count != 0)
            {
                FavoriteSongs.ForEach(song => { Console.WriteLine(song.Title); });
            }
            else
                Console.WriteLine("This person hates music");
        }
    }

}
