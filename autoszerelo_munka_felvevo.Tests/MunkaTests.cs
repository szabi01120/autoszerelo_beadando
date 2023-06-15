using autoszerelo_munka_felvevo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace autoszerelo_munka_felvevo.Tests
{
    [TestClass]
    public class MunkaTests
    {
        [TestMethod]
        public void UgyfelNeve_ShouldHaveErrorMessage_WhenEmpty()
        {
            // Arrange
            var munka = new Munka { UgyfelNeve = "" };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Ügyfél neve kötelezõ.", results[0].ErrorMessage);
        }

        [TestMethod]
        public void AutoTipusRendszam_ShouldHaveErrorMessage_WhenInvalidFormat()
        {
            // Arrange
            var munka = new Munka { AutoTipusRendszam = "ABC-1234" };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Autó típusa és rendszáma nem lehet üres és nem tartalmazhat speciális karaktereket. Rendszám formátuma: XXX-000", results[0].ErrorMessage);
        }

        [TestMethod]
        public void GyartasiEv_ShouldHaveErrorMessage_WhenInvalidFormat()
        {
            // Arrange
            var munka = new Munka { GyartasiEv = 2022 };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Gyártási év csak számokat tartalmazhat.", results[0].ErrorMessage);
        }

        [TestMethod]
        public void MunkaKategoria_ShouldHaveErrorMessage_WhenInvalidValue()
        {
            // Arrange
            var munka = new Munka { MunkaKategoria = "szervíz" };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Érvénytelen munka kategória.", results[0].ErrorMessage);
        }

        [TestMethod]
        public void HibaSulyossaga_ShouldHaveErrorMessage_WhenOutOfRange()
        {
            // Arrange
            var munka = new Munka { HibaSulyossaga = 0 };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("A hiba súlyossága 1 és 10 közötti szám lehet.", results[0].ErrorMessage);
        }
    }
}
