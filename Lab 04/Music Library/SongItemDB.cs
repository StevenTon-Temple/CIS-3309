using SongClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Music_Library
{

    public static class SongItemDB
    {
        private const string Path = @"..\..\SongList.txt";


        public static List<Song> GetItems()
        {

            List<Song> songs = new List<Song>();

            StreamReader reader = null;
            try
            {
                FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(fs);
                while(reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] column = line.Split('|');
                    Song song = new Song();
                    song.Title = column[0];
                    song.Artist = column[1];
                    song.Album = column[2];
                    song.Genre = column[3];
                    song.ReleaseYear = column[4];
                    song.Duration_Time = column[5];
                    song.song_Description = column[6];
                    song.imgUrl = column[7];
                    songs.Add(song);
                    
                }
            }
            catch (Exception crash)
            {
                MessageBox.Show(crash.ToString());

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return songs;
        }

        public static void SaveSongs(List<Song> songs)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
                foreach(Song song in songs)
                {
                    writer.Write(song.Title + "|");
                    writer.Write(song.Artist + "|");
                    writer.Write("" + song.Album + "|");
                    writer.Write(song.Genre + "|");
                    writer.Write(song.ReleaseYear + "|");
                    writer.Write(song.Duration_Time + "|");
                    writer.Write(song.song_Description + "|");
                    writer.WriteLine(song.imgUrl);


                }
            }
            catch(Exception crash)
            {
                MessageBox.Show(crash.ToString());
                return;
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }

        }
       
    }
}