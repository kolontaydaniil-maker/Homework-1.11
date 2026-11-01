//Задание 1
//using System;

//struct Vector
//{
//    public int X, Y, Z;

//    public Vector(int x, int y, int z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }

//    public static Vector operator *(Vector a, int n)
//    {
//        return new Vector(a.X * n, a.Y * n, a.Z * n);
//    }

//    public static Vector operator +(Vector a, Vector b)
//    {
//        return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
//    }

//    public static Vector operator -(Vector a, Vector b)
//    {
//        return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Vector a = new Vector(2, 3, 4);
//        Vector b = new Vector(1, 2, 3);

//        Vector c = a * 2;
//        Vector d = a + b;
//        Vector e = a - b;

//        Console.WriteLine($"{c.X} {c.Y} {c.Z}");
//        Console.WriteLine($"{d.X} {d.Y} {d.Z}");
//        Console.WriteLine($"{e.X} {e.Y} {e.Z}");
//    }
//}

//Задание 2
//using System;

//struct DecimalNumber
//{
//    public int Number;

//    public DecimalNumber(int number)
//    {
//        Number = number;
//    }

//    public string Binary()
//    {
//        return Convert.ToString(Number, 2);
//    }

//    public string Octal()
//    {
//        return Convert.ToString(Number, 8);
//    }

//    public string Hex()
//    {
//        return Convert.ToString(Number, 16);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DecimalNumber number = new DecimalNumber(100);

//        Console.WriteLine(number.Binary());
//        Console.WriteLine(number.Octal());
//        Console.WriteLine(number.Hex());
//    }
//}

//Задание 3
//using System;

//struct RGB
//{
//    public int R, G, B;

//    public RGB(int r, int g, int b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }

//    public string HEX()
//    {
//        return $"#{R:X2}{G:X2}{B:X2}";
//    }

//    public string HSL()
//    {
//        double r = R / 255.0;
//        double g = G / 255.0;
//        double b = B / 255.0;

//        double max = Math.Max(r, Math.Max(g, b));
//        double min = Math.Min(r, Math.Min(g, b));
//        double h = 0, s = 0;
//        double l = (max + min) / 2;

//        if (max != min)
//        {
//            double d = max - min;
//            s = l > 0.5 ? d / (2 - max - min) : d / (max + min);

//            if (max == r)
//                h = (g - b) / d + (g < b ? 6 : 0);
//            else if (max == g)
//                h = (b - r) / d + 2;
//            else
//                h = (r - g) / d + 4;

//            h *= 60;
//        }

//        return $"{h:F0}, {s * 100:F0}%, {l * 100:F0}%";
//    }

//    public string CMYK()
//    {
//        double r = R / 255.0;
//        double g = G / 255.0;
//        double b = B / 255.0;

//        double k = 1 - Math.Max(r, Math.Max(g, b));
//        double c = 0, m = 0, y = 0;

//        if (k != 1)
//        {
//            c = (1 - r - k) / (1 - k);
//            m = (1 - g - k) / (1 - k);
//            y = (1 - b - k) / (1 - k);
//        }

//        return $"{c * 100:F0}%, {m * 100:F0}%, {y * 100:F0}%, {k * 100:F0}%";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        RGB color = new RGB(255, 0, 128);

//        Console.WriteLine(color.HEX());
//        Console.WriteLine(color.HSL());
//        Console.WriteLine(color.CMYK());
//    }
//}