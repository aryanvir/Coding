using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampCourseCsharp
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration; // An attrubute to the object of the class 
        public static int songCount = 0; // An atribute to the class 

        public Song(string songTitle,string songArtist, int songDuration)
        {
            title = songTitle;
            artist = songArtist;
            duration = songDuration;
            songCount++;

        }
    }
}
