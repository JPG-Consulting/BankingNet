using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BankingNet
{
    public class Iban
    {
        #region Propiedades

        public string CountryCode { get; private set; }

        public byte CheckSum { get; private set; }

        public string Bban { get; private set; }


        #endregion

        #region Métodos
        
        private static bool ValidateCheckSum(String value)
        {
            string bank = value.Substring(4, value.Length - 4) + value.Substring(0, 4);
            int asciiShift = 55;
            StringBuilder sb = new StringBuilder();
            foreach (char c in bank)
            {
                int v;
                if (Char.IsLetter(c)) v = c - asciiShift;
                else v = int.Parse(c.ToString());
                sb.Append(v);
            }
            string checkSumString = sb.ToString();
            int checksum = int.Parse(checkSumString.Substring(0, 1));
            for (int i = 1; i < checkSumString.Length; i++)
            {
                int v = int.Parse(checkSumString.Substring(i, 1));
                checksum *= 10;
                checksum += v;
                checksum %= 97;
            }
            return checksum == 1;
        }

        public static bool Validate(string value)
        {
            Regex regex = new Regex("^([a-zA-Z]{2})([0-9]{2})([A-Za-z0-9-]{1,30})$");
            Match m = regex.Match(value);

            if (!m.Success)
            {
                // TODO: Error de formato
                return false;
            }

            string countryCode = m.Groups[1].Value.ToUpper();
            byte checkSum = Convert.ToByte(m.Groups[2].Value);
            string bban = m.Groups[3].Value;

            IbanStructure structure = IbanStructure.Get(countryCode);
            if (structure == null)
            {
                // TODO: Invalid country
                return false;
            }

            regex = new Regex(structure.Pattern);
            m = regex.Match(value);

            if (!m.Success)
            {
                // TODO: Error de formato
                return false;
            }

            if (!ValidateCheckSum(countryCode + checkSum.ToString() + bban))
            {
                // TODO: Invalid checksum
                return false;
            }

            // TODO: Validaciones de país
            if (countryCode.Equals("ES"))
            {
                return ValidateBbanCheckSumEs(bban);
            }

            return true;
        }

        /// <summary>
        /// Obtiene el dígito de control de una cuenta bancaria. La función sólo devuelve un número
        /// que corresponderá a una de las dos opciones.
        ///     - Codigo + CódigoOficina
        ///     - CuentaBancaria
        /// </summary>
        private static string GetDigitoControl(string CadenaNumerica)
        {
            int[] pesos = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            UInt32 suma = 0;
            UInt32 resto;

            for (int i = 0; i < pesos.Length; i++)
            {
                suma += (UInt32)pesos[i] * UInt32.Parse(CadenaNumerica.Substring(i, 1));
            }
            resto = 11 - (suma % 11);

            if (resto == 10) resto = 1;
            if (resto == 11) resto = 0;

            return resto.ToString();
        }

        // ObtenerDigitoControl
        private static bool ValidateBbanCheckSumEs(string value)
        {
            
            string pre = "00" + value.Substring(0, 8);
            string post = value.Substring(10);
            string dc = GetDigitoControl(pre);
            dc += GetDigitoControl(post);

            return dc.Equals(value.Substring(8,2));
        }

        #endregion

        #region Constructores

        protected Iban(string countryCode, byte checkSum, string bban)
        {
            this.CountryCode = countryCode;
            this.CheckSum = checkSum;
            this.Bban = bban;
        }

        #endregion
    }
}
