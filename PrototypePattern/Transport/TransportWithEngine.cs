namespace PrototypePattern
{
    /// <summary>
    /// Транспорт с двигателем (наследник транспорта и имеет уникальное для транспорта с двигателем свойство - макисмальная скорость).
    /// </summary>
    public class TransportWithEngine : Transport, IMyCloneable<TransportWithEngine>
    {
        public TransportWithEngine(double weight, double maxSpeed)
            : base(weight)
        {
            this.MaxSpeed = maxSpeed;
        }
        
        /// <summary>
        /// Максимальная скорость транспорта.
        /// </summary>
        public double MaxSpeed { get; set; }

        public override TransportWithEngine MyClone() => new(this.Weight, this.MaxSpeed);

        public override object Clone() => new TransportWithEngine(this.Weight, this.MaxSpeed);
    }
}