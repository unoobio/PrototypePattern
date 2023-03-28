namespace PrototypePattern
{
    /// <summary>
    /// Базовый класс для транспорта.
    /// </summary>
    public class Transport : IMyCloneable<Transport>, ICloneable
    {
        public Transport(double weight)
        {
            this.Weight = weight;
        }
        
        /// <summary>
        /// Вес транспорта.
        /// </summary>
        public double Weight { get; set; }

        public virtual Transport MyClone() => new(this.Weight);

        public virtual object Clone() => new Transport(this.Weight);
    }
}