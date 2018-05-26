namespace PsyxCalc.Subatomic
{
    public sealed class Electron
    {
        /// <summary>
        /// A nondimensional spin
        /// </summary>
        public static float Spin { get; set; } = 0.5f;

        /// <summary>
        /// Mass in Kilograms
        /// </summary>
        public static double Mass { get; set; } = 9.1094e-31;

        /// <summary>
        /// Charge (kg * m^2 * s^−1)
        /// </summary>
        public static float Charge { get; set; } = -1f;
    }
}