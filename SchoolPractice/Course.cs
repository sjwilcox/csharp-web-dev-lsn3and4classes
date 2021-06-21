using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolPractice
{
    class Course
    {
        public String ClassName { get; set; }
        public int ClassCatNum { get; set; }
        private List<string> ClassRoster = new List<string>();
        public void AddClassRoster(string names)
        {
            names = null;
            if (names != null)
            {
                ClassRoster.Add(names);
            }
        }

        
    }
}
