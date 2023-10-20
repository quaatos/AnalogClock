namespace clock
{
    internal class Angle
    {
        public static Point EndPoint(double deg, int length)
        {
            return new Point(CalcX(deg, length), CalcY(deg, length));
        }

        /// <summary>
        /// Calculate end X of pointer
        /// </summary>
        /// <returns>The end X of the pointer</returns>
        /// <algo>
        /// Calculate the "Overstaande rechthoekzijde" using Math.Sin(radius)
        /// Determine the length of the pointer by adding a value + X / 2; The longer the value is, the higher the pointer
        /// Typecast X to int (doesn't work with doubles)
        /// </algo>
        public static int CalcX(double deg, int length)
        {
            double o = Math.Sin(ToRadius(deg));
            double xLength = o * length + Form1.width / 2;
            return (int)xLength;
        }

        /// <summary>
        /// Calculate end Y of pointer
        /// </summary>
        /// <returns>The end Y of the pointer</returns>
        /// <algo>
        /// Calculate the "Aanliggende rechthoekzijde" using Math.Cos(radius)
        /// </algo>
        public static int CalcY(double deg, int length)
        {
            double a = Math.Cos(ToRadius(deg));
            double yLength = a * -length + Form1.height / 2;
            return (int)yLength;
        }

        /// <summary>
        /// Convert degrees to radius.
        /// </summary>
        public static double ToRadius(double angel)
        {
            return angel * Math.PI * 2 / 360;
        }
    }
}
