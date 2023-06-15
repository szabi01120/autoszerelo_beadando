using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoszerelo_szerver.Model
{
    public class Munka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ügyfél neve kötelező.")]
        [RegularExpression(@"^[^\s!?_\-:;#]+$", ErrorMessage = "Ügyfél név nem lehet üres és nem tartalmazhat speciális karaktereket.")]
        public string UgyfelNeve { get; set; }

        [Required(ErrorMessage = "Az autó típusa kötelező.")]
        [RegularExpression(@"^(?!.*[!?\s_\-:;#])\S+$", ErrorMessage = "Autó típusa nem lehet üres és nem tartalmazhat speciális karaktereket.")]
        public string Tipus { get; set; }

        [Required(ErrorMessage = "Az autó rendszáma kötelező.")]
        [RegularExpression(@"^(?![\s!?_\-:;#])^[A-Z]{3}-\d{3}$", ErrorMessage = "Az autó rendszáma nem lehet üres és nem tartalmazhat speciális karaktereket. Rendszám formátuma: XXX-000")]
        public string Rendszam { get; set; }

        [Required(ErrorMessage = "Gyártási év kötelező.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Gyártási év csak számokat tartalmazhat.")]
        public int GyartasiEv { get; set; }

        [Required(ErrorMessage = "Munka kategória kötelező.")]
        [RegularExpression(@"^(Karosszéria|motor|futómű|fékberendezés)$", ErrorMessage = "Érvénytelen munka kategória.")]
        public string MunkaKategoria { get; set; }

        [Required(ErrorMessage = "Az autó hibájának leírása kötelező.")]
        public string HibaLeiras { get; set; }

        [Required(ErrorMessage = "A hiba súlyossága kötelező.")]
        [Range(1, 10, ErrorMessage = "A hiba súlyossága 1 és 10 közötti szám lehet.")]
        public int HibaSulyossaga { get; set; }
        public double MunkaOra { get; set; }

        [RegularExpression(@"^(Felvett munka|Elvégzés alatt|Befejezett)$", ErrorMessage = "Érvénytelen munka állapot.")]
        public string MunkaAllapota { get; set; }
    }
}
