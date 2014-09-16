using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/// <summary>
/// Summary description for Encriptar
/// </summary>
public static class Encriptar
{
	
		public static String MD5hash(String sPalabra)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(sPalabra));
            byte[] resultado = md5.Hash;

            StringBuilder strBuilder= new StringBuilder();
            for (int i = 0; i < resultado.Length ; i++)
            {
                strBuilder.Append(resultado[i].ToString("x2"));
                
            }
            return strBuilder.ToString();
        }

    
}