using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatb1_html_to_ER
{
    public class Kapcsolat
    {

        string egyedANev;
        string egyedBNev;
        string szamossag;
        string[] buffer;
        public int kezd_pos_x { get; set; }
        public int kezd_pos_y { get; set; }
        public int veg_pos_x { get; set; }
        public int veg_pos_y { get; set; }
        public int fel_pos_x { get; set; }
        public int fel_pos_y { get; set; }

        public void Feltolt(string input)
        {
            buffer = input.Split('\"');
            this.egyedANev = buffer[1];
            this.egyedBNev = buffer[3];
            this.szamossag = buffer[5];
        }

        public Kapcsolat()
        {
            kezd_pos_x = 0;
            kezd_pos_y = 0;
            veg_pos_x = 0;
            veg_pos_y = 0;
            fel_pos_x = 0;
            fel_pos_y = 0;
        }

        public void kapcsolatpos(Egyed[] egyedek)
        {
            
            for (int i = 0; i < egyedek.Length; i++)
            {
                if (egyedek[i].név.Equals(egyedANev))
                {
                    kezd_pos_x = egyedek[i].pos_x;
                    kezd_pos_y = egyedek[i].pos_x;
                }
                else if (egyedek[i].név.Equals(egyedBNev))
                {
                    veg_pos_x = egyedek[i].pos_x;
                    veg_pos_y = egyedek[i].pos_x;
                }
            }
            fel_pos_x = Convert.ToInt32((kezd_pos_x + veg_pos_x) / 2);
            fel_pos_y = Convert.ToInt32((kezd_pos_y + veg_pos_y) / 2);
        }
    }
}
