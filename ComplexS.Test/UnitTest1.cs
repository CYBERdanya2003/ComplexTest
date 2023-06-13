namespace ComplexS.Test
{
    [TestFixture]
    public class ComplexTests
    {

        private const double Tolerance = 1e-13;

        [Test]
        public void TestEquals()
        {
            Complex c1 = new Complex(2.5, 3.45);
            Complex c2 = new Complex(2.5, 3.45);
            Assert.That(c1, Is.EqualTo(c2));
            Assert.That(c1, Is.EqualTo((object)c2));
            Assert.That(c1.GetHashCode(), Is.EqualTo(c2.GetHashCode()));
        }

        [Test]
        public void TestNotEquals()
        {
            Complex c1 = new Complex(2.5, 3.45);
            Complex c2 = new Complex(1.2, 4.0);
            Assert.That(c1, Is.Not.EqualTo(c2));
            Assert.That(c1, Is.Not.EqualTo((object)c2));
            Assert.That(c1.GetHashCode(), Is.Not.EqualTo(c2.GetHashCode()));
        }

        [Test]
        public void TestToString()
        {
            Complex z = new Complex(2.5, 3.45);
            string expected = "2,5 + 3,45i"; 
            string result = z.ToString();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestAddition()
        {
            Complex c1 = new Complex(2.5, 3.45);
            Complex c2 = new Complex(1.2, 4.0);
            Complex expected = new Complex(3.7, 7.45);
            Complex result = c1 + c2;
            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Tolerance));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Tolerance));
        }

        [Test]
        public void TestSubtraction()
        {
            Complex c1 = new Complex(2.5, 3.45);
            Complex c2 = new Complex(1.2, 4.0);
            Complex expected = new Complex(1.3, -0.55);
            Complex result = c1 - c2;
            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Tolerance));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Tolerance));
        }

        [Test]
        public void TestMultiplication()
        {
            Complex z1 = new Complex(2, 3);
            Complex z2 = new Complex(4, 5);
            Complex expected = new Complex(-7.0, 22.0); 
            Complex result = z1 * z2;
            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Tolerance));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Tolerance));
        }

        [Test]
        public void TestDivision()
        {
            Complex z1 = new Complex(1, 2);
            Complex z2 = new Complex(3, 4);
            Complex expected = new Complex(0.44, 0.08); 
            Complex result = z1 / z2;
            Assert.That(result.Re, Is.EqualTo(expected.Re).Within(Tolerance));
            Assert.That(result.Im, Is.EqualTo(expected.Im).Within(Tolerance));
        }
    }
}