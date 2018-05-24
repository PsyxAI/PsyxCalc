namespace PsyxCalc
{
    public static partial class Calc
    {
        public static double Mod(double x, double y) => x % y;
        public static float Mod(float x, float y) => x % y;
        public static int Mod(int x, int y) => (x % y);
        public static long Mod(long x, long y) => (x % y);
        public static short Mod(short x, short y) => (short)(x % y);
        public static byte Mod(byte x, byte y) => (byte)(x % y);
    }
}