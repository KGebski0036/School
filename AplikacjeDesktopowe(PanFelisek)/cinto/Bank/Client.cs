using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client
    {
        private List<Account> accounts_ = new List<Account>();
        public string Name_ {get;set;}
        public string Nazwisko_ { get; set; }
        public string Pesel_ { get; set; }
        public Client(string name, string nazwisko, string pesel)
        {
            Name_ = name;
            Nazwisko_ = nazwisko;
            Pesel_ = pesel;
        }

        
    }
}
