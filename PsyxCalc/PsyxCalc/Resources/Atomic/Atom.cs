namespace PsyxCalc.Atomic
{
    public abstract class Atom
    {
        /// <summary>
        /// The Atomic number of the element
        /// </summary>
        public abstract short AtomicNumber { get; set; }

        /// <summary>
        /// The Atomic mass
        /// </summary>
        public abstract short AtomicMass { get; set; }

        /* Commented out because of design flaws

        /// <summary>
        /// Number of electrons
        /// </summary>
        public abstract short ElectronCount { get; set; }

        /// <summary>
        /// The melting point of the substance in Kelvin.
        /// </summary>
        public abstract float MeltingPoint { get; set; }

        /// <summary>
        /// The boiling point of the substance in Kelvin
        /// </summary>
        public abstract float BoilingPoint { get; set; }

        /// <summary>
        /// Density of the substance at Liquid form
        /// </summary>
        public abstract float DensityLiquid { get; set; }

        */

        // TODO
    }
}
