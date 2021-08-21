using System;

/// <summary>
/// VectorMath class
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculate Magnitude of 2D or 3D vectore
    /// </summary>
    /// <param name="vector">vector</param>
    /// <returns>magnitude or -1 if its not a vector</returns>
    public static double Magnitude(double[] vector)
    {
        double sum = 0;

        if (vector.Length != 3 && vector.Length != 2)
        {
            return (-1);
        }
        foreach (var elem in vector)
        {
            sum += Math.Pow(elem, 2);
        }
        return System.Math.Round(System.Math.Sqrt(sum), 2);
    }
}
   

