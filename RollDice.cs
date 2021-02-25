using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary Classe para lançamento dos dados
/// </summary>
public class ClassRoll
{
    public ClassRoll()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //Metodo responsável por lançamento dos dados, com o algoritimo PROVABLY FAIR!
    public static double roll(String serverSeed, String clientSeed)
    {
        var key = Encoding.UTF8.GetBytes(serverSeed);
        HMACSHA512 sha512 = new HMACSHA512(key);
        var data = Encoding.UTF8.GetBytes(clientSeed);
        var result = sha512.ComputeHash(data);
        string hex = BitConverter.ToString(result).Replace("-", string.Empty);
        double value = double.MaxValue;
        int i = 0;
        while (value > 999999)
        {
            value = int.Parse(hex.Substring(i, 5), System.Globalization.NumberStyles.HexNumber);
            i += 5;
        }
        double resultRoll = value % (10000) / 100;
        return resultRoll;
    }
}
