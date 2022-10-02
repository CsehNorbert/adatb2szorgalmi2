using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatb1_html_to_ER
{
    public class Egyed
    {
        public string név { get; set; }
        string[] buffer;
        Tulajdonsag[] tulajdonságok;
        Circle tulCircle;
        public int pos_x { get; set; }
        public int pos_y { get; set; }

        public void Feltolt(List<string> input)
        {
            int numOfTul = 0;
            int TulCounter = 0;
            foreach (string line in input)
            {
                if (line.Contains("<TULAJDONSAG"))
                {
                    numOfTul++;
                }
            }
            tulajdonságok = new Tulajdonsag[numOfTul];
            for (int i = 0; i < tulajdonságok.Length; i++)
            {
                tulajdonságok[i] = new Tulajdonsag();
            }

            foreach (string item in input)
            {
                if (item.Contains("<EGYED"))
                {
                    
                    buffer = item.Split('"');
                    this.név = buffer[1];
                   
                }
                else if (item.Contains("<TULAJDONSAG"))
                {
                    tulajdonságok[TulCounter].Feltolt(item);
                    TulCounter++;
                }
                /*else 
                { 

                }*/
            }

        }

        public void tulajdonsagkor()
        {
            int[] x_ek = new int[tulajdonságok.Length];
            int[] y_ok = new int[tulajdonságok.Length];
            tulCircle = new Circle(pos_x,pos_y,200);
            tulCircle.feloszt(x_ek, y_ok);
                for (int i = 0; i < tulajdonságok.Length; i++)
                {
                    tulajdonságok[i].pos_x = x_ek[i];
                    tulajdonságok[i].pos_y = y_ok[i];
                }
            
        }

        public Egyed()
        {
            pos_x = 0;
            pos_y = 0;
        }

    }

}
