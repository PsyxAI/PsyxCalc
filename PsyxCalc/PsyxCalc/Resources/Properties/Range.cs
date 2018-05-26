namespace PsyxCalc.Properties
{
    public sealed class Range1D
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Start of range
        /// </summary>
        public double X
        {
            get => _x;
            set
            {
                _x = value;
                OnChanged();
            }
        }

        /// <summary>
        /// End of range
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                _y = value;
                OnChanged();
            }
        }

        public Range1D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"{X} - {Y}";
        public override bool Equals(object obj) => GetHashCode() == obj.GetHashCode();
        public override int GetHashCode() => ToString().GetHashCode();
        public static bool operator ==(Range1D r1, Range1D r2) => r1.Equals(r2);
        public static bool operator !=(Range1D r1, Range1D r2) => !r1.Equals(r2);
        public static bool operator >(Range1D r1, Range1D r2) => (r1.Y - r1.X) > (r2.Y - r2.X);
        public static bool operator <(Range1D r1, Range1D r2) => (r1.Y - r1.X) < (r2.Y - r2.X);
        public static bool operator >(Range1D r1, int r2) => (r1.Y - r1.X) > r2;
        public static bool operator <(Range1D r1, int r2) => (r1.Y - r1.X) < r2;
        public static bool operator >(Range1D r1, double r2) => (r1.Y - r1.X) > r2;
        public static bool operator <(Range1D r1, double r2) => (r1.Y - r1.X) < r2;
        public static bool operator >(Range1D r1, float r2) => (r1.Y - r1.X) > r2;
        public static bool operator <(Range1D r1, float r2) => (r1.Y - r1.X) < r2;
        public static bool operator >(Range1D r1, long r2) => (r1.Y - r1.X) > r2;
        public static bool operator <(Range1D r1, long r2) => (r1.Y - r1.X) < r2;
        public static bool operator >=(Range1D r1, Range1D r2) => (r1.Y - r1.X) >= (r2.Y - r2.X);
        public static bool operator <=(Range1D r1, Range1D r2) => (r1.Y - r1.X) <= (r2.Y - r2.X);
        public static bool operator >=(Range1D r1, int r2) => (r1.Y - r1.X) >= r2;
        public static bool operator <=(Range1D r1, int r2) => (r1.Y - r1.X) <= r2;
        public static bool operator >=(Range1D r1, double r2) => (r1.Y - r1.X) >= r2;
        public static bool operator <=(Range1D r1, double r2) => (r1.Y - r1.X) <= r2;
        public static bool operator >=(Range1D r1, float r2) => (r1.Y - r1.X) >= r2;
        public static bool operator <=(Range1D r1, float r2) => (r1.Y - r1.X) <= r2;
        public static bool operator >=(Range1D r1, long r2) => (r1.Y - r1.X) >= r2;
        public static bool operator <=(Range1D r1, long r2) => (r1.Y - r1.X) <= r2;
        public static explicit operator double(Range1D r1) => (r1.Y - r1.X);
        public static explicit operator float(Range1D r1) => (float)(r1.Y - r1.X);

        public delegate void Range1DChangedEventHandler(object source, System.EventArgs e);
        public event Range1DChangedEventHandler Range1DChanged;
        void OnChanged() => Range1DChanged?.Invoke(this, System.EventArgs.Empty);
    }
}
