using ClockTimeConfig;
using QuaatClock;

namespace clock;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public static Point start;
    public static double width, height;
    public static int hour, minute, second;

    private void Form1_Load(object sender, EventArgs e)
    {
        Time.Start();

        width = DrawingArea.Width;
        height = DrawingArea.Height;

        start.X = DrawingArea.Width / 2;
        start.Y = DrawingArea.Height / 2;
    }

    private void Time_Tick(object sender, EventArgs e)
    {
        hour = TimeValue.Hour();
        minute = TimeValue.Minute();
        second = TimeValue.Seconds();

        Drawing.DrawPointer(start, DrawingArea);
        Text = $"{hour}:{minute}:{second}";
    }

    private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
    {
        MessageBox.Show($"X: {e.X}\nY:{e.Y}");
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        Drawing.Ellipse(start.X, start.Y, DrawingArea);
        Drawing.DrawNumbers(start.X, start.Y, DrawingArea);
    }
}
