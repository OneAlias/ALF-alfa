using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace advancedLyricsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALF, the advanced lyrics finder, a project of the cxemabonny company");
            Console.Write("type the lyric you need here:");

            //questa variabile rappresenta la costante (k) mySong in riferimento alla canzone scelta in base al readline
            var mySong =
                    Console.ReadLine();
            //cosa inutile ma figa da vedre
            Console.Write(mySong);Console.WriteLine("  ~elaborating ...");

            //method per il primo testo aka Cups~Anna Kendric
            void cups()
            {
                StreamReader tx = new StreamReader("cups.txt");
                string t = tx.ReadLine();
                List<string> lyric = new List<string>();

                while (t != null)
                {
                    lyric.Add(t);
                    t = tx.ReadLine();
                }
                tx.Close();
                foreach (var item in lyric)
                {
                    Console.WriteLine(item);
                }
            }

            if (mySong == "cups")
                cups();

        }
    }
}
