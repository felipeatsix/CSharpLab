using System;

namespace BasicClass
{
    public class Human
    {
        public Human(DateTime birthday)
        {
            Birthday = birthday;
        }
        public DateTime Birthday { get; protected set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthday;
                return timeSpan.Days / 365;
            }
        }
    }
}