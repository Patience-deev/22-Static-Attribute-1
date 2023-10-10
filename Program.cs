using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Static_Attribute_1
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songcount = 0;
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songcount++;
        }

        static void Main(string[] args)
        {
            Songs holiday = new Songs("holiday",  "green day", 1);
            Songs kashmir = new Songs("kashmir","Led Zeppelin", 1);

            Console.WriteLine(Songs.songcount);
            Console.ReadLine();
        }
    }
}
