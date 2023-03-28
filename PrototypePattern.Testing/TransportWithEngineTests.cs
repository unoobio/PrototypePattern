namespace PrototypePattern.Testing
{
    [TestFixture]
    public class TransportWithEngineTests
    {
        [Test]
        public void Clone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var transport1 = new TransportWithEngine(1000, 200);
            var transport2 = (TransportWithEngine)(transport1 as ICloneable).Clone();
            Assert.Multiple(() =>
            {
                Assert.That(transport2.Weight, Is.EqualTo(transport1.Weight));
                Assert.That(transport2.MaxSpeed, Is.EqualTo(transport1.MaxSpeed));
            });
        }

        [Test]
        public void MyClone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var transport1 = new TransportWithEngine(1000, 200);
            var transport2 = transport1.MyClone();
            Assert.Multiple(() =>
            {
                Assert.That(transport2.Weight, Is.EqualTo(transport1.Weight));
                Assert.That(transport2.MaxSpeed, Is.EqualTo(transport1.MaxSpeed));
            });
        }
    }
}