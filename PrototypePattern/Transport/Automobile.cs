namespace PrototypePattern
{
    /// <summary>
    /// Автомобиль (наследуется от транспорта с двигателем и имеет уникальное свойство - тип привода).
    /// </summary>
    public class Automobile : TransportWithEngine, IMyCloneable<Automobile>
    {
        public Automobile(double weight, double maxSpeed, TypeOfDrive typeOfDrive)
            : base(weight, maxSpeed)
        {
            this.TypeOfDrive = typeOfDrive;
        }

        /// <summary>
        /// Тип привода.
        /// </summary>
        public TypeOfDrive TypeOfDrive { get; set; }

        public override Automobile MyClone() => new(this.Weight, this.MaxSpeed, this.TypeOfDrive);

        public override object Clone() => new Automobile(this.Weight, this.MaxSpeed, this.TypeOfDrive);
    }
}