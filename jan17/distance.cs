using System;
abstract class Distance_converter //Abstract class created
{
    public abstract double m_km(double input);
    public static double km_m(double input);
    public static double mi_km(double input);
    public static double km_mi(double input);
}
class conversion : Distance_converter
{
    public override double m_km(double input)
    {
        double km = 0;
        km = input / 1000;
        Console.WriteLine(" Result in Kilometer " + km);
    }

    public override double km_m(double input)
    {
        double m = 0;
        m = input * 1000;
        Console.WriteLine(" Result in Meter " + m);
    }

    public override double mi_km(double input)
    {
        double m = 0;
        km = input * 1.609;
        Console.WriteLine(" Result in Kilometer " + km);
    }

    public override double km_mi(double input)
    {
        double mi = 0;
        mi = input / 1.609;
        Console.WriteLine(" Result in Mile " + mi);
    }
}
class user_main
{

    static void Main()
    {
        conversion c = new conversion();
        Console.WriteLine("Distance convertion Calculator");
        Console.WriteLine("1. Kilometer to Meter\n 2. Meter to Kilometer\n3. Mile to Kilometer\n4. Kilometer to Mile");
        int choice = Convert.ToInt32(Console.ReadLine());
        double input, m = 0, km = 0, mi = 0;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Kilometer \n");
                input = double.Parse(Console.ReadLine());
                m = c.km_m(input);
                break;

            case 2:
                Console.WriteLine("Enter Meter \n");
                input = double.Parse(Console.ReadLine());
                km = c.m_km(input);
                break;

            case 3:
                Console.WriteLine("Enter Mile \n");
                input = double.Parse(Console.ReadLine());
                km = c.mi_km(input);
                break;

            case 4:
                Console.WriteLine("Enter Kilometer \n");
                input = double.Parse(Console.ReadLine());
                mi = c.km_mi(input);
                break;
        }
    }
}
