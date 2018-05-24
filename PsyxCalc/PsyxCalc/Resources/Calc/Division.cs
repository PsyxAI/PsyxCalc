namespace PsyxCalc
{
    public static partial class Calc
    {
        public static double Divide(double x, double y) => x / y;
        public static float Divide(float x, float y) => x / y;
        public static int Divide(int x, int y) => x / y;
        public static long Divide(long x, long y) => x / y;
        public static short Divide(short x, short y) => (short)(x / y);
        public static byte Divide(byte x, byte y) => (byte)(x / y);
    }
}