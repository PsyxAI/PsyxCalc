namespace PsyxCalc
{
    public static partial class Calc
    {

        #region Traditional Types

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static double Round(double x) => ((long)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static int Round(int x) => ((int)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static long Round(long x) => ((long)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static float Round(float x) => ((long)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static short Round(short x) => ((short)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static byte Round(byte x) => ((byte)(x + 0.5));

        /// <summary>
        /// Rounds the given number to the nearest 1
        /// </summary>
        public static decimal Round(decimal x) => ((long)(x + 0.5m));

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static double Round(double x, double roundTo)
        {
            return ((long)((x / roundTo) + 0.5)) * roundTo;
        }

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static float Round(float x, float roundTo)
        {
            return ((long)((x / roundTo) + 0.5f)) * roundTo;
        }

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static decimal Round(decimal x, decimal roundTo)
        {
            return ((long)((x / roundTo) + 0.5m)) * roundTo;
        }

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static int Round(int x, int roundTo)
        {
            return ((int)((x / roundTo) + 0.5)) * roundTo;
        }

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static long Round(long x, long roundTo)
        {
            return ((long)((x / roundTo) + 0.5)) * roundTo;
        }

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded number</returns>
        public static byte Round(byte x, byte roundTo)
        {
            return (byte)((byte)((x / roundTo) + 0.5) * (double)roundTo);
        }

        #endregion Traditional Types

        #region Custom Types

        /// <summary>
        /// Rounds the given number to the nearest "roundTo"
        /// </summary>
        /// <param name="x">Number to round up</param>
        /// <param name="roundTo">Round to the nearest *this number*</param>
        /// <returns>Rounded range</returns>
        public static PsyxCalc.Properties.Range1D Round(PsyxCalc.Properties.Range1D x, double roundTo)
        {
            return new PsyxCalc.Properties.Range1D(Round(x.X, roundTo), Round(x.Y, roundTo));
        }

        #endregion Custom Types
    }
}