using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingNet
{
    public class IbanStructure
    {

        public string Pattern { get; private set; }

        public BbanStructure BbanStructure { get; private set; }

        public static Dictionary<string, IbanStructure> GetAll()
        {
            return new Dictionary<String, IbanStructure> {
                { "AD", new IbanStructure() { Pattern = @"^AD\d{10}[0-9A-Z]{12}$" } },
                { "AE", new IbanStructure() { Pattern = @"^AE\d{21}$" } },
                { "AL", new IbanStructure() { Pattern = @"^AL\d{10}[0-9A-Z]{16}$" } },
                { "AT", new IbanStructure() { Pattern = @"^AT\d{18}$" } },
                { "BA", new IbanStructure() { Pattern = @"^BA\d{18}$" } },
                { "BE", new IbanStructure() { Pattern = @"^BE\d{14}$" } },
                { "BG", new IbanStructure() { Pattern = @"^BG\d{2}[A-Z]{4}\d{6}[0-9A-Z]{8}$" } },
                { "BH", new IbanStructure() { Pattern = @"^BH\d{2}[A-Z]{4}[0-9A-Z]{14}$" } },
                { "CH", new IbanStructure() { Pattern = @"^CH\d{7}[0-9A-Z]{12}$" } },
                { "CY", new IbanStructure() { Pattern = @"^CY\d{10}[0-9A-Z]{16}$" } },
                { "CZ", new IbanStructure() { Pattern = @"^CZ\d{22}$" } },
                { "DE", new IbanStructure() { Pattern = @"^DE\d{20}$" } },
                { "DK", new IbanStructure() { Pattern = @"^DK\d{16}$|^FO\d{16}$|^GL\d{16}$" } },
                { "DO", new IbanStructure() { Pattern = @"^DO\d{2}[0-9A-Z]{4}\d{20}$" } },
                { "EE", new IbanStructure() { Pattern = @"^EE\d{18}$" } },
                { "ES", new IbanStructure() { Pattern = @"^ES\d{22}$" } },
                { "FI", new IbanStructure() { Pattern = @"^FI\d{16}$" } },
                { "FR", new IbanStructure() { Pattern = @"^FR\d{12}[0-9A-Z]{11}\d{2}$" } },
                { "GB", new IbanStructure() { Pattern = @"^GB\d{2}[A-Z]{4}\d{14}$" } },
                { "GE", new IbanStructure() { Pattern = @"^GE\d{2}[A-Z]{2}\d{16}$" } },
                { "GI", new IbanStructure() { Pattern = @"^GI\d{2}[A-Z]{4}[0-9A-Z]{15}$" } },
                { "GR", new IbanStructure() { Pattern = @"^GR\d{9}[0-9A-Z]{16}$" } },
                { "HR", new IbanStructure() { Pattern = @"^HR\d{19}$" } },
                { "HU", new IbanStructure() { Pattern = @"^HU\d{26}$" } },
                { "IE", new IbanStructure() { Pattern = @"^IE\d{2}[A-Z]{4}\d{14}$" } },
                { "IL", new IbanStructure() { Pattern = @"^IL\d{21}$" } },
                { "IS", new IbanStructure() { Pattern = @"^IS\d{24}$" } },
                { "IT", new IbanStructure() { Pattern = @"^IT\d{2}[A-Z]\d{10}[0-9A-Z]{12}$" } },
                { "KW", new IbanStructure() { Pattern = @"^KW\d{2}[A-Z]{4}22!$" } },
                { "KZ", new IbanStructure() { Pattern = @"^[A-Z]{2}\d{5}[0-9A-Z]{13}$" } },
                { "LB", new IbanStructure() { Pattern = @"^LB\d{6}[0-9A-Z]{20}$" } },
                { "LI", new IbanStructure() { Pattern = @"^LI\d{7}[0-9A-Z]{12}$" } },
                { "LT", new IbanStructure() { Pattern = @"^LT\d{18}$" } },
                { "LU", new IbanStructure() { Pattern = @"^LU\d{5}[0-9A-Z]{13}$" } },
                { "LV", new IbanStructure() { Pattern = @"^LV\d{2}[A-Z]{4}[0-9A-Z]{13}$" } },
                { "ME", new IbanStructure() { Pattern = @"^ME\d{20}$" } },
                { "MK", new IbanStructure() { Pattern = @"^MK\d{5}[0-9A-Z]{10}\d{2}$" } },
                { "MR", new IbanStructure() { Pattern = @"^MR13\d{23}$" } },
                { "MT", new IbanStructure() { Pattern = @"^MT\d{2}[A-Z]{4}\d{5}[0-9A-Z]{18}$" } },
                { "MU", new IbanStructure() { Pattern = @"^MU\d{2}[A-Z]{4}\d{19}[A-Z]{3}$" } },
                { "NL", new IbanStructure() { Pattern = @"^NL\d{2}[A-Z]{4}\d{10}$" } },
                { "NO", new IbanStructure() { Pattern = @"^NO\d{13}$" } },
                { "PL", new IbanStructure() { Pattern = @"^PL\d{10}[0-9A-Z]{,16}n$" } },
                { "PT", new IbanStructure() { Pattern = @"^PT\d{23}$" } },
                { "RO", new IbanStructure() { Pattern = @"^RO\d{2}[A-Z]{4}[0-9A-Z]{16}$" } },
                { "RS", new IbanStructure() { Pattern = @"^RS\d{20}$" } },
                { "SA", new IbanStructure() { Pattern = @"^SA\d{4}[0-9A-Z]{18}$" } },
                { "SE", new IbanStructure() { Pattern = @"^SE\d{22}$" } },
                { "SI", new IbanStructure() { Pattern = @"^SI\d{17}$" } },
                { "SK", new IbanStructure() { Pattern = @"^SK\d{22}$" } },
                { "SM", new IbanStructure() { Pattern = @"^SM\d{2}[A-Z]\d{10}[0-9A-Z]{12}$" } },
                { "TN", new IbanStructure() { Pattern = @"^TN59\d{20}$" } },
                { "TR", new IbanStructure() { Pattern = @"^TR\d{7}[0-9A-Z]{17}$" } },
            };
        }

        public static IbanStructure Get(string countryCode)
        {
            Dictionary<string, IbanStructure> all = GetAll();

            if (!all.ContainsKey(countryCode))
            {
                return null;
            }

            return all[countryCode];
        }

        protected IbanStructure()
        {
        }
    }
}
