namespace PsyxCalc
{
    public static class ExtensionMethods
    {

        public static int Round(this int x, int roundTo) => PsyxCalc.Calc.Round(x, roundTo);
        public static int Round(this int x) => PsyxCalc.Calc.Round(x);
        //TODO
    }
}
