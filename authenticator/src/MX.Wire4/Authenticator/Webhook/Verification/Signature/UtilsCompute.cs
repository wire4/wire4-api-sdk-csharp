using System;
using System.Text;
using System.Security.Cryptography;

namespace MX.Wire4.Authenticator.Webhook.Verification.Signature
{
    /// <summary>
    /// Represents a set of utils for webHook verification signatures
    /// </summary>
    public class UtilsCompute
    {
        
        /// <summary>
        /// Compara de forma segura dos firmas en su representación de cadena de texto para comprobar sí son iguales. El
        /// tiempo que toma la comparación es independiente del número de carácteres de las cadenas a comparar.
        /// </summary>
        /// 
        /// <param name="message">el mensaje a firmar.</param>
        /// <param name="key">la llave usada para generar la firma.</param>
        /// <param name="headerSignature">la firma recibida en el encabezado del mensaje WebHook.</param>
        /// <returns><code>true</code> sí y sólo sí, las firmas coinciden, <code>false</code> en otro caso.</returns>
        public static bool CompareWebHookMsgSignatures(string message, string key, string headerSignature)
        {
            byte[] hash = UtilsCompute.ComputeHmacSha512(message, key);
            string hashStr = UtilsCompute.AsHexString(hash);
            bool result = MessageDisgestIsEqual(Encoding.UTF8.GetBytes(hashStr),
                                                Encoding.UTF8.GetBytes(headerSignature));

            return result;
        }

        /// <summary>
        /// Obtiene la firma usando HMAC/SHA-512 para un mensaje y la llave especificada.
        /// </summary>
        /// 
        /// <param name="message">el mensaje a firmar.</param>
        /// <param name="secret">la llave usada para generar la firma.</param>
        /// <returns>la firma como un arreglo de bytes.</returns>
        private static byte[] ComputeHmacSha512(string message, string secret)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secret);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            HMACSHA512 cryptographer = new HMACSHA512(keyBytes);

            return cryptographer.ComputeHash(messageBytes);
        }

        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";

            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }
            return (sbinary);
        }

        /// <summary>
        /// Converts an array of bytes into a String representing the hexadecimal values of each byte in order. The returned
        /// String will be double the length of the passed array, as it takes two characters to represent any given byte.
        /// </summary>
        /// 
        /// <param name="hash">to convert to Hex characters</param>
        /// <returns>A string containing lower-case hexadecimal characters.</returns>
        private static String AsHexString(byte[] hash)
        {

            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Compares two digests for equality. Does a simple byte compare.
        /// </summary>
        /// 
        /// <param name="digesta">one of the digests to compare.</param>
        /// <param name="digestb">the other digest to compare.</param>
        /// <returns>true if the digests are equal, false otherwise.</returns>
        private static bool MessageDisgestIsEqual(byte[] digesta, byte[] digestb)
        {
            if (digesta == digestb) return true;
            if (digesta == null || digestb == null)
            {
                return false;
            }

            if (digesta.Length != digestb.Length)
            {
                return false;
            }

            int result = 0;
            // time-constant comparison
            for (int i = 0; i < digesta.Length; i++)
            {
                result |= digesta[i] ^ digestb[i];
            }

            return result == 0;
        }
    }
}
