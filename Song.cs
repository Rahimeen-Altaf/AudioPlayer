using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }

        public Song(int songID, string title)
        {
            SongID = songID;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
