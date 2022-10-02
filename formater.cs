using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatb1_html_to_ER
{
    public static class formater
    {
        public static void create_clases(String[] inputstring,ref Egyed[] egyedtomb, ref Kapcsolat[] kapcsolattomb)
        {  

            bool egyed = false;
            int egyedCounter = 0;
            int kapcsolatCounter = 0;
            List<string> buffer= new List<string>();

            foreach (string line in inputstring)
            {
                if (line.Contains("</EGYED"))
                {
                    egyed = false;
                    buffer.Add(line);
                    egyedtomb[egyedCounter].Feltolt(buffer);
                    egyedCounter++;
                    buffer.Clear();
                }
                else if(line.Contains("<EGYED")||egyed)
                {
                    egyed = true;
                    buffer.Add(line);
                }
                else if(line.Contains("<KAPCSOLAT"))
                {
                    kapcsolattomb[kapcsolatCounter].Feltolt(line);
                    kapcsolatCounter++;
                }
               

            }
        }
    }
}
