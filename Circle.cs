using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace adatb1_html_to_ER
{
    class Circle
    {
        int x, y, r;


        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public void feloszt(int[] x_ek, int[] y_ok)
        {
            double belsoszog;
            for (int i = 0; i < x_ek.Length; i++)
            {

                belsoszog = (i * (360 / x_ek.Length))+90;

                x_ek[i] = Convert.ToInt32(x + r * Math.Cos(belsoszog));
                y_ok[i] = Convert.ToInt32(y + r * Math.Sin(belsoszog));

            }
        }

    }
}
