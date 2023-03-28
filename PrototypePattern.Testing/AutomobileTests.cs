namespace PrototypePattern.Testing
{
    [TestFixture]
    public class AutomobileTests
    {
        [Test]
        public void Clone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var automobile1 = new Automobile(1000, 200, TypeOfDrive.Rear);
            var automobile2 = (Automobile)(automobile1 as ICloneable).Clone();
            Assert.Multiple(() =>
            {
                Assert.That(automobile2.Weight, Is.EqualTo(automobile1.Weight));
                Assert.That(automobile2.MaxSpeed, Is.EqualTo(automobile1.MaxSpeed));
                Assert.That(automobile2.TypeOfDrive, Is.EqualTo(automobile1.TypeOfDrive));
            });
        }

        [Test]
        public void MyClone_ShouldCreateCopyOfObjectWithSameProperties()
        {
            var automobile1 = new Automobile(1000, 200, TypeOfDrive.Rear);
            var automobile2 = automobile1.MyClone();
            Assert.Multiple(() =>
            {
                Assert.That(automobile2.Weight, Is.EqualTo(automobile1.Weight));
                Assert.That(automobile2.MaxSpeed, Is.EqualTo(automobile1.MaxSpeed));
                Assert.That(automobile2.TypeOfDrive, Is.EqualTo(automobile1.TypeOfDrive));
            });
        }
    }
}