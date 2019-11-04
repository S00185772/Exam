using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public enum Genre { Rock, Pop, Dance, Other };
    public  class Song /*: IComparable*/
    {
        public string Title { get;  set; }

        public string Artist { get;  set; }
      public  double Duration { get;  set; }
      public  Genre genre { get;  set; }

      public  Genre genre1;

        public Song(string title, string artist,double duration,Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            genre1 = genre;
        }

      
        public override string ToString()
        {
            return $"{Title}\t{Artist}\t{Duration}\t{genre1}";
        }

        //public int CompareTo(object obj)
        //{
        //    return Artist.CompareTo(obj);
        //}
    }
}
