using System;
namespace _3_magnitude
{
     static void Main(string[] args)
    {
        double[] vect = new double[] { 3, 2, 5 };
        var res = VectorMath.Magnitude(vect);
        Console.WriteLine(res);
    }
}
