using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    public class student
    {
        public student(string firstName, string LastName)
        {


            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException(nameof(firstName));


            this.firstName = firstName;
            this.LastName = LastName;


        }

        System.String firstName { get; set; }

        System.String LastName { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", firstName, LastName);
            }
        }

        private int Age
        {
            get
            {
                return 12;
            }
        }
    }
}
