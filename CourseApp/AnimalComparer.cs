using System;
using System.Collections;

namespace CourseApp
{
        public class AnimalComparer : IComparer
        {
            public int Compare(object o1, object o2)
            {
                Animal a1 = o1 as Animal;
                Animal a2 = o2 as Animal;
                return string.Compare(a1.Name, a2.Name);
            }
        }
}