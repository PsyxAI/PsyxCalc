namespace PsyxCalc.Subatomic
{
    public sealed class Photon
    {
        /// <summary>
        /// A nondimensional spin
        /// </summary>
        public float Spin { get; set; } = 1.0f;
        
        /// <summary>
        /// Mass in Kilograms
        /// </summary>
        public double Mass { get; set; } = 0;
        
        /// <summary>
        /// Charge (kg * m^2 * s^−1)
        /// </summary>
        public float Charge { get; set; } = 0;

        public static double Speed() => 299_792_458;

        //public static double Speed(IOptics obj) => 299_792_458;  TODO - IMPLEMENT OPTICAL PHYSICS
    }
}