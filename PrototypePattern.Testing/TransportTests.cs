namespace PrototypePattern.Testing
{
    [TestFixture]
    public class TransportTests
    {
        [Test]
        public void Clone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var transport1 = new Transport(1000);
            var transport2 = (Transport)(transport1 as ICloneable).Clone();

            Assert.That(transport2.Weight, Is.EqualTo(transport1.Weight));
        }

        [Test]
        public void MyClone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var transport1 = new Transport(1000);
            var transport2 = transport1.MyClone();

            Assert.That(transport2.Weight, Is.EqualTo(transport1.Weight));
        }
    }
}