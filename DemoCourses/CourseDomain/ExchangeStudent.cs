using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain
{
    public class ExchangeStudent : student
    {
        public ExchangeStudent(string firstName, string lastName, Country countryOfOrigin)
            :  base(firstName, lastName)
        {
            if (countryOfOrigin != null)
            {
                NativeLanguage = countryOfOrigin.Language != null ? countryOfOrigin.Language : string.Empty;
            }
        }

        public string NativeLanguage { get; private set; }

        
    }
}
