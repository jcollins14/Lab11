using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie
    {
        private string title;
        private string genre;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public Movie(string title, string genre)
        {
            this.Title = title;
            this.Genre = genre;
        }
    }
}
