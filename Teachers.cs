using System;
using System.Collections.Generic;
using System.Text;

namespace TTHK
{
    public class Teachers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }

        public string IsFullTime { get; set; }
        List<Course> Courses = new List<Course>();

        public Teachers(string firstname, string lastname, string personalcode, string isfulltime)
        {
            FirstName = firstname;
            LastName = lastname;
            PersonalCode = personalcode;
            IsFullTime = isfulltime;
            Courses = new List<Course>();
        }

        public void AddCourses(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourses(Course course)
        {
            Courses.Remove(course);
        }

        public override string ToString()
        {
            return FirstName + LastName + PersonalCode + IsFullTime;
        }

    }
}
