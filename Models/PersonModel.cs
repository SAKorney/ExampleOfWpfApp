using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWpf.Models
{
    public class PersonModel
    {
        private const string DefaultValue = "Anonym";

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public PersonModel(string firstName = DefaultValue, string secondName = DefaultValue)
        {
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
