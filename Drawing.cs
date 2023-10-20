using clock;
using ClockTimeConfig;

namespace QuaatClock
{
    //TODO: Making a better solution; calculate all pointer locations.
    //Than draw the seconds pointer to each location.
    public class Drawing
    {
        static double hourAngleDeg;
        static int minuteAngleDeg;
        static int secondAngleDeg;

        /// <summary>
        /// Draw a line between start & end, on control
        /// </summary>
        public static void DrawPointer(Point startLocation, Control here)
        {
            Graphics draw = here.CreateGraphics();

            draw.DrawLine(new Pen(here.BackColor, 1), startLocation, Angle.EndPoint(secondAngleDeg, 200));
            draw.DrawLine(new Pen(here.BackColor, 3), startLocation, Angle.EndPoint(minuteAngleDeg, 200));
            draw.DrawLine(new Pen(here.BackColor, 3), startLocation, Angle.EndPoint(hourAngleDeg, 200));

            hourAngleDeg = ((Form1.hour + 1.0 * Form1.minute / 60) * 30) - Math.PI / 2;
            minuteAngleDeg = 360 / 60 * Form1.minute;
            secondAngleDeg = 360 / 60 * Form1.second;

            draw.DrawLine(new Pen(Color.White, 4), startLocation, Angle.EndPoint(hourAngleDeg, 150));
            draw.DrawLine(new Pen(Color.White, 3), startLocation, Angle.EndPoint(minuteAngleDeg, 200));
            draw.DrawLine(new Pen(Color.Gold, 1), startLocation, Angle.EndPoint(secondAngleDeg, 200));
        }

        static int circleWidth = 450;
        static int circleHeight = 450;
        /// <summary>
        /// Draw an ellipse around the middle point of the control
        /// </summary>
        public static void Ellipse(int x, int y, Control here)
        {
            Pen pen = new Pen(new SolidBrush(Color.White), 3);
            Graphics g = here.CreateGraphics();
            g.DrawEllipse(pen, new Rectangle(x - circleWidth / 2, y - circleHeight / 2, circleWidth, circleHeight));
        }

        /// <summary>
        /// Draw the number 1 to 12 around a circle
        /// </summary>
        /// <algo>
        /// Count from 1 to 12 with a forloop.
        /// </algo>
        public static void DrawNumbers(int x, int y, Control here)
        {
            Brush brush = new SolidBrush(Color.White);
            Graphics g = here.CreateGraphics();
            Font arial = new Font("Arial", 15, FontStyle.Bold);
            int num = 1;

            for (int i = 30; i <= 30 * 12; i += 360 / 12) //30 * 12 = 360 & 360 / 12 = 30
            {
                g.DrawString(num.ToString(), arial, brush, new PointF(Angle.EndPoint(i, 200).X - 10, Angle.EndPoint(i, 200).Y - 10));
                num++;
            }
        }
    }
}