using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//the good one
namespace SongClassLibrary
{
    public class Song
    {

        string songTitle;
        string artist;
        string albumName;
        string genre;
        string duration_Time;
        string description;
        string imgURL;
        string releaseYear;

        public Song() { 
        }

        public Song(string songTitle, string artist, string albumName, 
            string genre, string releaseYear, string duration_Time, 
            string description, string imgURL)
        {
            this.Title = songTitle;
            this.Artist = artist;
            this.Album = albumName;
            this.Genre = genre;
            this.ReleaseYear = releaseYear;
            this.Duration_Time = duration_Time;
            this.song_Description = description;
            this.imgUrl = imgURL;
        }
        public string Title
        {
            get { return songTitle; }
            set{songTitle = value;}
        }
        public string Artist
        {
            get
            {return artist;}
            set
            { artist = value;}
        }
        public string Album
        {
            get
            { return albumName; }
            set
            { albumName = value; }
        }
        public string Genre
        {
            get
            { return genre;
            }
            set
            { genre = value;
            }
        }
        public string ReleaseYear
        {
            get
            {return releaseYear;}
            set
            {releaseYear = value;}
        }
        public string Duration_Time
        {
            get
            {return duration_Time;}
            set
            {duration_Time = value;}
        }
        public string song_Description
        {
            get 
            { return description; 
            }
            set
            {description = value;
            }

        }
        public string imgUrl
        {
            get{return imgURL; }
            set{imgURL = value;}
        }
    }
}
