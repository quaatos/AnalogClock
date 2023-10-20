namespace ClockTimeConfig
{
    public class TimeValue 
    {
        public static int Hour() 
        {
            return DateTime.Now.Hour;
        }
        
        public static int Minute()
        {
            return DateTime.Now.Minute;
        }

        public static int Seconds()
        {
            return DateTime.Now.Second;
        }
    }
}
