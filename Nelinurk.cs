using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Nelinurk
    {
        int korgus;
        int laius;
        private int umber;
        private int ala;
        private string tuup;



        public Nelinurk() { }
        public Nelinurk(int Korgus, int Laius)
        {
            korgus = Korgus;
            laius = Laius;
        }
        public int Korgus
        {
            get { return korgus; }
        }
        public int Laius
        {
            get { return laius; }
        }
        public string Tuup
        {
            get
            {
                if (laius == korgus)
                {
                    tuup = "võrdkülgsed";
                }
                else
                {
                    tuup = "ristkülik";
                }
                return tuup;
            }
        }
        public double Umbermoot
        {
            get 
            {
                umber = (korgus + laius) * 2;
                return umber; 
            }
        }
        public double Ala
        {
            get 
            {
                ala = korgus * laius;
                return ala; 
            }
        }
        public void Info()
        {
            Console.WriteLine("Ala on {0}cm^2 ja Ümbermõõs on {1}cm. See on {2} nelinurk", Ala, Umbermoot, Tuup);
        }
    }
}
