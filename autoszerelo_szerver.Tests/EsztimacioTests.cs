using autoszerelo_szerver.Functions;
using autoszerelo_szerver.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace autoszerelo_szerver.Tests
{
	[TestClass]
	public class EsztimacioTests
	{
		[TestMethod]
		public void TestMunkaEsztimacio_KarosszeriaCategory_CalculatesCorrectly()
		{
			// Arrange
			var munka = new Munka
			{
				GyartasiEv = 2015,
				MunkaKategoria = "Karossz�ria",
				HibaSulyossaga = 8
			};

			// Act
			var result = Esztimacio.MunkaEsztimacio(munka);

			// Assert
			Assert.AreEqual(2.4, result);
		}

		[TestMethod]
		public void TestMunkaEsztimacio_MotorCategory_CalculatesCorrectly()
		{
			// Arrange
			var munka = new Munka
			{
				GyartasiEv = 1998,
				MunkaKategoria = "motor",
				HibaSulyossaga = 4
			};

			// Act
			var result = Esztimacio.MunkaEsztimacio(munka);

			// Assert
			Assert.AreEqual(6.4, result);
		}

		[TestMethod]
		public void TestMunkaEsztimacio_FutomuCategory_CalculatesCorrectly()
		{
			// Arrange
			var munka = new Munka
			{
				GyartasiEv = 2010,
				MunkaKategoria = "fut�m�",
				HibaSulyossaga = 2
			};

			// Act
			var result = Esztimacio.MunkaEsztimacio(munka);

			// Assert
			Assert.AreEqual(1.8	, result);
		}

		[TestMethod]
		public void TestMunkaEsztimacio_FekberendezesCategory_CalculatesCorrectly()
		{
			// Arrange
			var munka = new Munka
			{
				GyartasiEv = 2020,
				MunkaKategoria = "f�kberendez�s",
				HibaSulyossaga = 10
			};

			// Act
			var result = Esztimacio.MunkaEsztimacio(munka);

			// Assert
			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void TestMunkaEsztimacio_Between_5_7_Category_CalculatesCorrectly()
		{
			// Arrange
			var munka = new Munka
			{
				GyartasiEv = 2020,
				MunkaKategoria = "f�kberendez�s",
				HibaSulyossaga = 6
			};

			// Act
			var result = Esztimacio.MunkaEsztimacio(munka);

			// Assert
			Assert.AreEqual(1.2, result);
		}
	}
}
