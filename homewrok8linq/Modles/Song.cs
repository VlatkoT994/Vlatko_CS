using System;
using System.Collections.Generic;
using System.Text;

namespace Modles
{
    public class Song
    {
        public string Title;
        public int Length;
        public Genre MusicGenre;
        public Song(string title, int length, Genre genre)
        {
            Title = title;
            Length = length;
            MusicGenre = genre;
        }

    }
}
