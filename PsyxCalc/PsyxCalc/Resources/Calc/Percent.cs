namespace PsyxCalc
{
    public static partial class Calc
    {
        public static double Percent(double x, double y) => ((x / y) * 100);
        public static float Percent(float x, float y) => (x / y) * 100;
        public static int Percent(int x, int y) => (x / y) * 100;
        public static long Percent(long x, long y) => (x / y) * 100;
        public static short Percent(short x, short y) => (short)((x / y) * 100);
        public static byte Percent(byte x, byte y) => (byte)((x / y) * 100);
    }
}