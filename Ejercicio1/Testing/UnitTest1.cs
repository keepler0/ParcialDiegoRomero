using Ejercicio1.Entidades;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarValores()
        {
            int a = 6;
            int b = 10;
            int c = 50;
            var p = new PiramideCuadrada(a, b, c);
            Assert.IsTrue(p.validar());
        }
    }
}