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
            Boolean Account;
            Regex r = new Regex("^[a-zA-Z0-9' ]+$");
            if (r.IsMatch(s))
            {
                Account = true;
            }
            else
            {
                Account = false;
            }
            return Account;
        }

        public Boolean IsAmount(string s)
        {
            Boolean amount;

            Regex r = new Regex(@"^[0-9]+\.[0-9]{2}$");
            if (r.IsMatch(s))
            {
                amount = true;
            }
            else
            {
                amount = false;
            }
            return amount;
        }

        public Boolean isAccountNumber(string s)
        {
            Boolean amount;

            Regex r = new Regex("^[0-9]{9}$");
            if (r.IsMatch(s))
            {
                amount = true;
            }
            else
            {
                amount = false;
            }
            return amount;
        }
        
        public Boolean isIBAN(string s)
        {
            Boolean IBAN;

            Regex r = new Regex("^(?:(?:IT|SM)[0-9]{2}[A-Z][0-9]{22}|CY[0-9]{2}[A-Z][0-9]{23}|NL[0-9]{2}[A-Z]{4}[0-9]{10}|LV[0-9]{2}[A-Z]{4}[0-9]{13}|(?:BG|BH|GB|IE)[0-9]{2}[A-Z]{4}[0-9]{14}|GI[0-9]{2}[A-Z]{4}[0-9]{15}|RO[0-9]{2}[A-Z]{4}[0-9]{16}|KW[0-9]{2}[A-Z]{4}[0-9]{22}|MT[0-9]{2}[A-Z]{4}[0-9]{23}|NO[0-9]{13}|(?:DK|FI|GL|FO)[0-9]{16}|MK[0-9]{17}|(?:AT|EE|KZ|LU|XK)[0-9]{18}|(?:BA|HR|LI|CH|CR)[0-9]{19}|(?:GE|DE|LT|ME|RS)[0-9]{20}|IL[0-9]{21}|(?:AD|CZ|ES|MD|SA)[0-9]{22}|PT[0-9]{23}|(?:BE|IS)[0-9]{24}|(?:FR|MR|MC)[0-9]{25}|(?:AL|DO|LB|PL)[0-9]{26}|(?:AZ|HU)[0-9]{27}|(?:GR|MU)[0-9]{28})$");
            if (r.IsMatch(s))
            {
                IBAN = true;
            }
            else
            {
                IBAN = false;
            }
            return IBAN;
        }

    }
}