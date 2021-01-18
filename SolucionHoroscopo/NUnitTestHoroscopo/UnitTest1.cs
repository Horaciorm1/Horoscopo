using NUnit.Framework;
using WebHoroscopo.Controllers;

namespace NUnitTestHoroscopo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHoroscopoGet()
        {
            //Arrange=preparacion
            int dia = 1;
            int mes = 11;
            string esperado = "Escorpion: Si un Escorpio no confía en alguien, puedes estar seguro de que tiene buenas razones.";
            HoroscopoController Hor = new HoroscopoController();


            //Act=ejecution
            string resultado = Hor.Get(dia, mes);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestHoroscopoPost()
        {
            //Arrange=preparacion
            int dia = 20;
            int mes = 8;
            string esperado = "Leo: Nada da más placer en la vida que lograr aquello que dicen que no eres capaz de hacer.";
            HoroscopoController Hor = new HoroscopoController();


            //Act=ejecution
            string resultado = Hor.Post(dia, mes);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }

    }
}