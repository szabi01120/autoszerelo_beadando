using System.ComponentModel.DataAnnotations;

namespace autoszerelo_munka_felvevo.Model
{
    public class Munka
    {
        [Required(ErrorMessage = "Ügyfél neve kötelező.")]
        [RegularExpression(@"^[^\s!?_\-:;#]+$", ErrorMessage = "Ügyfél név nem lehet üres és nem tartalmazhat speciális karaktereket.")]
        public string UgyfelNeve { get; set; }

        [Required(ErrorMessage = "Autó típusa és rendszáma kötelező.")]
        [RegularExpression(@"^(?!.*[\s!?_\-:;#])^[A-Z]{3}-\d{3}$", ErrorMessage = "Autó típusa és rendszáma nem lehet üres és nem tartalmazhat speciális karaktereket. Rendszám formátuma: XXX-000")]
        public string AutoTipusRendszam { get; set; }

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
    }
}
