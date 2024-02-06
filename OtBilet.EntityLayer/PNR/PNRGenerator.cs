using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtBilet.EntityLayer;
public class PNRGenerator
{
    private static readonly string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private static Random random = new Random();
    public static string GeneratePNR()
    {
        char[] pnrArray = new char[6];

        for (int i = 0; i < 6; i++)
        {
            pnrArray[i] = Characters[random.Next(Characters.Length)];
        }

        return new string(pnrArray);
    }



}
