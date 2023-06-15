using autoszerelo_munka_felvevo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace autoszerelo_munka_felvevo.Tests
{
    [TestClass]
    public class MunkaTests
    {
        [TestMethod]
        public void TestCustomerNameValidation()
        {
            string customerName = "Alma Panna";
            bool isValid = ValidateCustomerName(customerName);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidCustomerName()
        {
            string customerName = "!@#$";
            bool isValid = ValidateCustomerName(customerName);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestCarTypeValidation()
        {
            string carType = "Merci";
            bool isValid = ValidateCarType(carType);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidCarType()
        {
            string carType = "!@#$";
            bool isValid = ValidateCarType(carType);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestLicensePlateFormatValidation()
        {
            string licensePlate = "ABC-123";
            bool isValid = ValidateLicensePlateFormat(licensePlate);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidLicensePlateFormat()
        {
            string licensePlate = "ABC123";
            bool isValid = ValidateLicensePlateFormat(licensePlate);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestManufacturingYearValidation()
        {
            int manufacturingYear = 2010;
            bool isValid = ValidateManufacturingYear(manufacturingYear);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidManufacturingYear()
        {
            int manufacturingYear = 2025;
            bool isValid = ValidateManufacturingYear(manufacturingYear);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestJobCategoryValidation()
        {
            string jobCategory = "motor";
            bool isValid = ValidateJobCategory(jobCategory);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidJobCategory()
        {
            string jobCategory = "brakes";
            bool isValid = ValidateJobCategory(jobCategory);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestShortDescriptionValidation()
        {
            string shortDescription = "Engine problem";
            bool isValid = ValidateShortDescription(shortDescription);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidShortDescription()
        {
            string shortDescription = "";
            bool isValid = ValidateShortDescription(shortDescription);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestSeverityValidation()
        {
            int severity = 5;
            bool isValid = ValidateSeverity(severity);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidSeverity()
        {
            int severity = 15;
            bool isValid = ValidateSeverity(severity);
            Assert.IsFalse(isValid);
        }

        private bool ValidateCustomerName(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
                return false;

            string pattern = @"^[^!?_\-:;#]+$";
            return Regex.IsMatch(customerName, pattern);
        }

        private bool ValidateCarType(string carType)
        {
            if (string.IsNullOrWhiteSpace(carType))
                return false;

            string pattern = @"^[^!?_\-:;#]+$";
            return Regex.IsMatch(carType, pattern);
        }

        private bool ValidateLicensePlateFormat(string licensePlate)
        {
            string pattern = @"^[A-Z]{3}-\d{3}$";
            return Regex.IsMatch(licensePlate, pattern);
        }

        private bool ValidateManufacturingYear(int manufacturingYear)
        {
            int currentYear = DateTime.Now.Year;
            return manufacturingYear <= currentYear && manufacturingYear >= 1900;
        }

        private bool ValidateJobCategory(string jobCategory)
        {
            string[] validCategories = { "Karosszéria", "motor", "futómû", "fékberendezés" };
            return Array.Exists(validCategories, category => category.Equals(jobCategory, StringComparison.InvariantCultureIgnoreCase));
        }

        private bool ValidateShortDescription(string shortDescription)
        {
            return !string.IsNullOrWhiteSpace(shortDescription);
        }

        private bool ValidateSeverity(int severity)
        {
            return severity >= 1 && severity <= 10;
        }

    }
}
