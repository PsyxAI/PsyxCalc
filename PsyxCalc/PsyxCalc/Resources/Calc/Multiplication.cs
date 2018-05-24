namespace PsyxCalc
{
    public static partial class Calc
    {
        public static double Mult(double x, double y) => x * y;
        public static float Mult(float x, float y) => x * y;
        public static int Mult(int x, int y) => x * y;
        public static long Mult(long x, long y) => x * y;
        public static short Mult(short x, short y) => (short)(x * y);
        public static byte Mult(byte x, byte y) => (byte)(x * y);
    }
}