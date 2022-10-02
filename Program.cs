using System;
using System.IO;




namespace adatb1_html_to_ER
{
    class Program
    {
        const int x_length = 1000;
        const int y_length = 1000;

        static void Main(string[] args)
        {
            //inputing the file
            String[] lines = File.ReadAllLines("E:/adatb1/input.txt");

            //measuring how many objects we will need
            int numOfEgyeds = 0;
            int numOfKapcsolats = 0;
            foreach (string line in lines)
            {
                if (line.Contains("<EGYED"))
                    { 
                        numOfEgyeds++; 
                    }
                if (line.Contains("<KAPCSOLAT"))
                    {
                    numOfKapcsolats++;
                    }
            }

            //creating the empty classes
            Egyed[] egyedek = new Egyed[numOfEgyeds];
            for (int i = 0; i < egyedek.Length; i++)
            {
                egyedek[i] = new Egyed();
            }
            Kapcsolat[] kapcsolats = new Kapcsolat[numOfKapcsolats];
            for (int i = 0; i < kapcsolats.Length; i++)
            {
                kapcsolats[i] = new Kapcsolat();
            }

            //filling the classes up
            formater.create_clases(lines,ref egyedek, ref kapcsolats);

            //egyedek elhelyezése
            Circle mainCircle = new Circle(x_length / 2, y_length / 2, x_length / 4);
            int[] egyedekX = new int[numOfEgyeds];
            int[] egyedekY = new int[numOfEgyeds];
            mainCircle.feloszt(egyedekX, egyedekY);
            for (int i = 0; i < egyedekX.Length; i++)
            {
                egyedek[i].pos_x= egyedekX[i];
                egyedek[i].pos_y = egyedekY[i];
            }

            //tulajdonságok elhelyezése
            for (int i = 0; i < egyedek.Length; i++)
            {
                egyedek[i].tulajdonsagkor();
            }

            //kapcsolatok elhelyezése
            for (int i = 0; i < kapcsolats.Length; i++)
            {
                kapcsolats[i].kapcsolatpos(egyedek);
            }

            //Minden elemet beolvastunk, és kiszámoltuk a pozíciójat.
            //TO DO: kirajzolni
            //
            Console.ReadLine();
        }
    }
}
