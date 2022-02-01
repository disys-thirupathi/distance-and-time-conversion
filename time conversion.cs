using System;
namespace time_conv
{
    public abstract class time
    {
        public abstract double hr_m();
        public abstract int m_hr();
        public abstract int m_se();
        public abstract int se_m();
    }
    public class time : time_convert
    {
        public abstract override double hr_m(d)
        {
            int minute = 0;
            minute = hour * 60;
            Console.WriteLine("Hour in Minutes : " + minute);
        }
        public abstract override int m_hr()
        {
            double hour = 0;
            hour = min / 60;
            Console.WriteLine("Minutes in hour : " + hour);
        }
        public abstract override int m_se()
        {
            double second = 0;
            second = min * 60;
            Console.WriteLine("Minutes in second : " + second);
        }
        public abstract override int se_m()
        {
            double min = 0;
            min = sec / 60;
            Console.WriteLine("second in Minutes : " + min);
        }
    }
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            time tc = new time_convert();
            tc.hr_m(2.25);
            tc.m_hr(75);
            tc.m_se(88);
            tc.se_m(99);
        }
    }
}