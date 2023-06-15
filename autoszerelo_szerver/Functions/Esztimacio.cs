using autoszerelo_szerver.Model;
using Microsoft.AspNetCore.Mvc;

namespace autoszerelo_szerver.Functions
{
    public class Esztimacio
    {
        public static double MunkaEsztimacio(Munka akt_munka)
        {
            double szamitott_ora;
            int kategoria;
            double kor, sulyossag;
            int eletkor = DateTime.Today.Year - akt_munka.GyartasiEv;

            if (akt_munka.MunkaKategoria.Equals("Karosszéria"))
            {
                kategoria = 3;
            }
            else if (akt_munka.MunkaKategoria.Equals("motor"))
            {
                kategoria = 8;
            }
            else if (akt_munka.MunkaKategoria.Equals("futómű"))
            {
                kategoria = 6;
            }
            else
            {
                kategoria = 4;
            }

            if (eletkor <= 5)
            {
                kor = 0.5;
            }
            else if (eletkor <= 10)
            {
                kor = 1;
            }
            else if (eletkor <= 15)
            {
                kor = 1.5;
            }
            else
            {
                kor = 2;
            }
             
            if (akt_munka.HibaSulyossaga <= 2)
            {
                sulyossag = 0.2;
            }
            else if (akt_munka.HibaSulyossaga <= 4)
            {
                sulyossag = 0.4;
            }
            else if (akt_munka.HibaSulyossaga <= 6)
            {
                sulyossag = 0.6;
            }
            else if (akt_munka.HibaSulyossaga <= 8)
            {
                sulyossag = 0.8;
            }
            else
            { 
                sulyossag = 1;
            }

            szamitott_ora = kategoria * kor * sulyossag;
            return Math.Round(szamitott_ora, 2);
        }
    }
}
