using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatb1_html_to_ER
{
    class Tulajdonsag
    {

        bool kulcsertek;
        tipus tip;
        string név;
        string[] erték;
        string[] buffer;
        public int pos_x { get; set; }
        public int pos_y { get; set; }

        public void Feltolt(string input)
        {
            buffer = input.Split('\"');
            this.név = buffer[1];
            if (buffer[3] == "I")
            {
                this.kulcsertek = true;
            }
            if (buffer[5] == "I")
            {
                this.tip = tipus.normál;
            }
            else if (buffer[7] == "I")
            {
                this.tip = tipus.többértékű;
            }
            else if (buffer[9] == "I")
            {
                this.tip = tipus.származtatott;
            }
            else if (buffer[11] == "I")
            {
                this.tip = tipus.összetett;
            }
            this.erték = buffer[13].Split(",");
        }

        public Tulajdonsag()
        {
            pos_x = 0;
            pos_y = 0;
        }

        public Tulajdonsag(tipus t, string nev, string[] ertek)
        {
            tip = t;
            név = nev;
            erték = ertek;
        }
        
    }
}
