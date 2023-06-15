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
            Assert.AreEqual("�gyf�l neve k�telez�.", results[0].ErrorMessage);
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
            Assert.AreEqual("Aut� t�pusa �s rendsz�ma nem lehet �res �s nem tartalmazhat speci�lis karaktereket. Rendsz�m form�tuma: XXX-000", results[0].ErrorMessage);
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
            Assert.AreEqual("Gy�rt�si �v csak sz�mokat tartalmazhat.", results[0].ErrorMessage);
        }

        [TestMethod]
        public void MunkaKategoria_ShouldHaveErrorMessage_WhenInvalidValue()
        {
            // Arrange
            var munka = new Munka { MunkaKategoria = "szerv�z" };
            var context = new ValidationContext(munka);
            var results = new System.Collections.Generic.List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(munka, context, results, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("�rv�nytelen munka kateg�ria.", results[0].ErrorMessage);
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
            Assert.AreEqual("A hiba s�lyoss�ga 1 �s 10 k�z�tti sz�m lehet.", results[0].ErrorMessage);
        }
    }
}
