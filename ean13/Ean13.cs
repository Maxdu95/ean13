using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ean13
{
    class Ean13
    {
        private int[] ean13;

        public Ean13(int[] ean13)
        {
            int attendu = 0;
            if (ean13.Length < 12)
            {
                throw new Exception("Un code Ean 13 doit être un tableau de 12 entiers, trop petit");
            }
            if (ean13.Length > 12)
            {
                throw new Exception("Un code Ean 13 doit être un tableau de 12 entiers, trop grand");
            }

            foreach (int i in ean13)
            {
                if (i > 9)
                {
                    attendu = 1;
                }
            }
            if (attendu != 0)
            {
                throw new Exception("un élément du genocode n'est pas compris entre 0 et 9");
            }
            this.ean13 = ean13;
        } 

        public int PoidsPairs()
        {
            int cumul = 0;
            int poids;
            for (int i = 1; i < this.ean13.Length; i = i + 2)
            {
                cumul = cumul + ean13[i];
            }
            poids = cumul * 3;
            return poids;

        }

        public int PoidsImpairs()
        {
            int cumul = 0;
            int poids;
            for (int i = 0; i < this.ean13.Length; i = i + 2)
            {
                cumul = cumul + ean13[i];
            }
            poids = cumul * 1;
            return poids;
        }

        public int Reste()
        {
            int reste = (PoidsPairs() + PoidsImpairs()) % 10;
            return reste;
        }

        public int Cle()
        {
            int cle;
            int reste = Reste();
            if (reste == 0)
            {
                cle = 0;
            }
            else
            {
                cle = 10 - reste;
            }
            return cle;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                s = s + ean13[i];
            }
            s = s + "-";
            for (int i = 4; i < 8; i++)
            {
                s = s + ean13[i];
            }
            s = s + "-";
            for (int i = 8; i < 12; i++)
            {
                s = s + ean13[i];
            }
            s = s + "-" + this.Cle();
            return s;
        }
    }
}
