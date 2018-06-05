namespace PsyxCalc
{
    public static class ExtensionMethods
    {

        #region Round
        public static int Round(this int x, int roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static int Round(this int x) => PsyxCalc.Calc.Round(x);

        public static long Round(this long x, long roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static long Round(this long x) => PsyxCalc.Calc.Round(x);

        public static byte Round(this byte x, byte roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static byte Round(this byte x) => PsyxCalc.Calc.Round(x);

        public static double Round(this double x, double roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static double Round(this double x) => PsyxCalc.Calc.Round(x);

        public static float Round(this float x, float roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static float Round(this float x) => PsyxCalc.Calc.Round(x);

        public static decimal Round(this decimal x, decimal roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static decimal Round(this decimal x) => PsyxCalc.Calc.Round(x);
        #endregion Round


        //TODO
    }
}
