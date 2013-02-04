using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace PayrollSystem
{
    public class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            var finalString = "";
            for (var count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + "\n";

            }
           
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}