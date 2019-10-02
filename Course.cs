using System;
using System.Collections.Generic;
using System.Text;

namespace TTHK
{
    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

    }
}
