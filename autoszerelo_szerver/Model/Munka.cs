﻿using System.ComponentModel.DataAnnotations;

namespace autoszerelo_szerver.Model
{
    public class Munka
    {
        [Key]
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public string Rendszam { get; set; }
        public int Ev { get; set; }
        public string Kategoria { get; set; }
        public string Leiras { get; set; }
        public string Sulyossag { get; set; }
    }
}