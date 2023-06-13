using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoszerelo_munka_client.Model
{
    public class Munka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public string Nev { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public string Tipus { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public string Rendszam { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public int Ev { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public string Kategoria { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        public string Leiras { get; set; }
        [Required(ErrorMessage = "Kötelező mező!")]
        [Range(0, 10, ErrorMessage = "Ezen mező értéke 1 és 10 között kell, hogy legyen!")]
        public int Sulyossag { get; set; }
    }
}
