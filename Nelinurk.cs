using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Nelinurk
    {
        double korgus;
        double laius;
        private double umber;
        private double ala;
        private string tuup;
        private double diagonaal;


        public Nelinurk() { }
        public Nelinurk(double Korgus, double Laius)
        {
            korgus = Korgus;
            laius = Laius;
        }
        public double Korgus
        {
            set { if (korgus == 0) korgus = value; }
            get { return korgus; }
        }
        public double Laius
        {
            set { if (laius == 0) laius = value; }
            get { return laius; }
        }
        public string Tuup
        {
            get
            {
                if (laius == korgus)
                {
                    tuup = "ruut";
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
        public double Diagonaal
        {
            get
            {
                diagonaal = Math.Sqrt(korgus * korgus + laius * laius);
                return diagonaal;
            }
        }
        public void Info()
        {
            Console.WriteLine("Ala on {0}cm^2 ja Ümbermõõt on {1}cm. See on {2} nelinurk", Ala, Umbermoot, Tuup);
        }
        public void DiagonaalInfo()
        {
            Console.WriteLine("Diagonaal on {0} cm", Math.Round(Diagonaal,2));
        }
    }
}
