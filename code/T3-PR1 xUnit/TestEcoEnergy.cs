using System;

namespace T3PR1
{
    public class TestEcoEnergy
    {
        const int _minimEolic = 5;
        const int _minimHidroelectric = 20;
        const int _minimSolar = 1;

        //Tests sistemes eòlics
        [Fact]
        public void EolicValidarDadaInvalid()
        {
            //Arrange
            SistemaEolic sistemaEolic;
            //Act & Assert
            Assert.Throws<ArgumentException>(() => sistemaEolic = new SistemaEolic(DateTime.Now, 1));
        }

        [Fact]
        public void EolicValidarDadaValid()
        {
            //Arrange
            SistemaEolic sistemaEolic = new SistemaEolic(DateTime.Now, 15);
            //Act
            var result = sistemaEolic.ValidarDada(sistemaEolic.VelocitatVent, _minimEolic);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EolicValidarDadaLimit()
        {
            //Arrange
            SistemaEolic sistemaEolic = new SistemaEolic(DateTime.Now, 15);
            //Act
            var result = sistemaEolic.ValidarDada(sistemaEolic.VelocitatVent, _minimEolic);
            //Assert
            Assert.True(result);
        }

        //Tests sistemes solars
        [Fact]
        public void SolarValidarDadaInvalid()
        {
            //Arrange
            SistemaSolar sistemaSolar;
            //Act & Assert
            Assert.Throws<ArgumentException>(() => sistemaSolar = new SistemaSolar(DateTime.Now, 0));
        }

        [Fact]
        public void SolarValidarDadaValid()
        {
            //Arrange
            SistemaSolar sistemaSolar = new SistemaSolar(DateTime.Now, 12);
            //Act
            var result = sistemaSolar.ValidarDada(sistemaSolar.HoresSol, _minimSolar);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SolarValidarDadaLimit()
        {
            //Arrange
            SistemaSolar sistemaSolar = new SistemaSolar(DateTime.Now, 1);
            //Act
            var result = sistemaSolar.ValidarDada(sistemaSolar.HoresSol, _minimSolar);
            //Assert
            Assert.True(result);
        }

        //Tests sistemes hidroelèctrics
        [Fact]
        public void HidroelectricValidarDadaInvalid()
        {
            //Arrange
            SistemaHidroelectric sistemaHidroelectric;
            //Act & Assert
            Assert.Throws<ArgumentException>(() => sistemaHidroelectric = new SistemaHidroelectric(DateTime.Now, 10));
        }

        [Fact]
        public void HidroelectricaValidarDadaValid()
        {
            //Arrange
            SistemaHidroelectric sistemaHidroelectric = new SistemaHidroelectric(DateTime.Now, 35);
            //Act
            var result = sistemaHidroelectric.ValidarDada(sistemaHidroelectric.Cabal, _minimHidroelectric);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void HidroelectricaValidarDadaLimit()
        {
            //Arrange
            SistemaHidroelectric sistemaSolar = new SistemaHidroelectric(DateTime.Now, 20);
            //Act
            var result = sistemaSolar.ValidarDada(sistemaSolar.Cabal, _minimHidroelectric);
            //Assert
            Assert.True(result);
        }
    }
}