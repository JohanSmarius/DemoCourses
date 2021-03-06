﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    public class Class
    {
        public DateTime StartTime { get; set; }

        public System.Int32 Duration { get; set; }

        public DateTime EndTime
        {
            get
            {
                if (Duration > 0)
                {
                    return StartTime.AddHours(Duration);
                }
                else
                {
                    // Default 2 hours
                    return StartTime.AddHours(2);
                }

                return DateTime.Now;
            }
        }
    }

    public class Course
    {
        private List<student> students;
        private List<Class> _classes;

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<string> Goals { get; set; }

        public IEnumerable<student> Students => students;

        public void AddClass(DateTime startDate, int Duration, Instructor instructor)
        {
            if (instructor == null)
            {
                throw new ArgumentNullException(nameof(instructor));
            }

            Class NewClass = new Class();
            NewClass.StartTime = startDate;
            NewClass.Duration = Duration;

            this._classes.Add(NewClass);
        }

        public void AddClasses(DateTime startDate, int count, int duration)
        {
            int i = 0;
            var date = startDate;
            do {

            } while (i < count);
        }
    }
}
