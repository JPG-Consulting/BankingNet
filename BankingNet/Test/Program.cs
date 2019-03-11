using BankingNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ibans = new Dictionary<string, string> {
                { "GB33BUKB20201555555555", "IBAN, longitud, checksum, código bancario, cuenta y estructura válidos" },
                { "GB94BARC10201530093459", "IBAN válido, código bancario no encontrado (no se puede identificar el banco): longitud, checksum, código bancario, cuenta y estructura válidos" },
                { "GB94BARC20201530093459", "Dígitos de verificación MOD-97 - 10 de IBAN inválidos según el estándar ISO / IEC 7064:2003" },
                { "GB96BARC202015300934591", "Longitud de IBAN inválida, ¡debe tener una longitud de \"X\" caracteres!" },
                { "GB02BARC20201530093451", "Número de cuenta inválido" },
                { "GB68CITI18500483515538", "Número de cuenta inválido" },
                { "GB24BARC20201630093459", "Código bancario no encontrado y número de cuenta inválido" },
                { "GB12BARC20201530093A59", "Estructura de cuenta inválida" },
                { "GB78BARCO0201530093459", "Código bancario no encontrado y estructura de código bancario inválida" },
                { "GB2LABBY09012857201707", "Checksum de estructura de IBAN inválido" },
                { "GB01BARC20714583608387", "Checksum de IBAN inválida" },
                { "GB00HLFX11016111455365", "Checksum de IBAN inválida" },
                { "US64SVBKUS6S3300958879", "¡País no compatible con IBAN!" },
                // Medicos sin fronters
                { "ES8320480000273400106773", "Medicos Sin Fronteras (Liberbank )" },
                // Genware
                {"ES9614348598260926732057", "GENWARE" }
            };
            
            foreach (KeyValuePair<string, string> valor in ibans)
            {
                    bool valid = Iban.Validate(valor.Key);

                    Console.WriteLine(valor.Key + ": " + valid.ToString() + ": " + valor.Value);
                
            }
        }
    }
}
