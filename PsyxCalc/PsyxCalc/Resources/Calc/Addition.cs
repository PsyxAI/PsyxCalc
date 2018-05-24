namespace PsyxCalc
{
    public static partial class Calc
    {
        public static double Plus(double x, double y) => x + y;
        public static float Plus(float x, float y) => x + y;
        public static int Plus(int x, int y) => x + y;
        public static long Plus(long x, long y) => x + y;
        public static short Plus(short x, short y) => (short)(x + y);
        public static byte Plus(byte x, byte y) => (byte)(x + y);
    }
}