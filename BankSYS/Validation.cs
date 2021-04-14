using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankSYS
{
    class Validation
    {
        public Boolean IsAlphabetic(string s)
        {
            Boolean alphabetic;
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (r.IsMatch(s))
            {
                alphabetic = true;
            }
            else
            {
                alphabetic = false;
            }
            return alphabetic;
        }
        public Boolean IsAlphabeticNoSpace(string s)
        {
            Boolean alphabetic;
            Regex r = new Regex("^[a-zA-Z']+$");
            if (r.IsMatch(s))
            {
                alphabetic = true;
            }
            else
            {
                alphabetic = false;
            }
            return alphabetic;
        }
        public Boolean IsName(string s)
        {
            Boolean alphabetic;
            Regex r = new Regex("^[a-zA-Z']+$");
            if (r.IsMatch(s))
            {
                alphabetic = true;
            }
            else
            {
                alphabetic = false;
            }
            return alphabetic;
        }
        public Boolean IsNumeric(string s)
        {
            Boolean numeric;
            Regex r = new Regex("^[0-9]+$");
            if (r.IsMatch(s))
            {
                numeric = true;
            }
            else
            {
                numeric = false;
            }
            return numeric;
        }

        public Boolean IsAlphanumeric(string s)
        {
            Boolean alphanumeric;
            Regex r = new Regex("^[a-zA-Z0-9]+$");
            if (r.IsMatch(s))
            {
                alphanumeric = true;
            }
            else
            {
                alphanumeric = false;
            }
            return alphanumeric;
        }

        public Boolean IsEir(string s)
        {
            Boolean eir;
            Regex r = new Regex("[ACDEFHKNPRTVWXY]{1}[0-9]{2} ?[0-9ACDEFHKNPRTVWXY]{4}|(D6W) ?[0-9ACDEFHKNPRTVWXY]{4}");
            if (r.IsMatch(s))
            {
                eir = true;
            }
            else
            {
                eir = false;
            }
            return eir;
        }

        public Boolean IsPPS(string s)
        {
            Boolean pps;
            Regex r = new Regex("[0-9]{7}[A-Za-z]{1,2}");
            if (r.IsMatch(s))
            {
                pps = true;
            }
            else
            {
                pps = false;
            }
            return pps;
        }

        public Boolean IsEmpty(string s)
        {
            Boolean empty;
            if (s.Equals(""))
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            return empty;
        }

        public Boolean IsAccount(string s)
        {
            Boolean alphabetic;
            Regex r = new Regex("^[a-zA-Z0-9' ]+$");
            if (r.IsMatch(s))
            {
                alphabetic = true;
            }
            else
            {
                alphabetic = false;
            }
            return alphabetic;
        }

    }
}
