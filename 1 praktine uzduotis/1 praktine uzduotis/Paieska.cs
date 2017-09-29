using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _1_praktine_uzduotis
{
    class Paieska
    {
        string aplankas;
        public Stopwatch praejesLaikas = new Stopwatch();

        public Paieska(string aplankas)
        {
            this.aplankas = aplankas;
        }

        public List<string> rastiPasikartojanciusAplankus()
        {
            praejesLaikas.Start();

            string[] visiFailai = Directory.GetFiles(aplankas, "*", SearchOption.AllDirectories);
            // sarasas rastiFailai skirtas pasikartojanciu failu indeksams surasyti, kad ju nebetikrintu antra karta for cikle
            List<int> rastiFailai = new List<int>();
            List<string> pasikartojantysFailai = new List<string>();

            for (int i = 0; i < visiFailai.Length; i++)
            {
                for (int j = i + 1; j < visiFailai.Length; j++)
                {
                    if (rastiFailai.Contains(i)) break;
                    if (palygintiFailus(visiFailai[i], visiFailai[j]))
                    {
                        pasikartojantysFailai.Add(visiFailai[j]);
                        rastiFailai.Add(j);
                    }
                }
            }

            praejesLaikas.Stop();
            return pasikartojantysFailai;
        }

        bool palygintiFailus(string failas1, string failas2)
        {
            byte[] failas1_baitais = File.ReadAllBytes(failas1);
            byte[] failas2_baitais = File.ReadAllBytes(failas2);
            if (failas1_baitais.Length == failas2_baitais.Length)
            {
                for (int i = 0; i < failas1_baitais.Length; i++)
                {
                    if (failas1_baitais[i] != failas2_baitais[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }



    }
}
