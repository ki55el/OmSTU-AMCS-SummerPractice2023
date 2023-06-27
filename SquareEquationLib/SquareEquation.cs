namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double[] solution;
        const double eps = 1e-9;
        if (Math.Abs(a) < eps)
        {
            throw new System.ArgumentException();
        }
        if (Double.IsNaN(a) || Double.IsNaN(b) || Double.IsNaN(c) ||
            Double.IsInfinity(a) || Double.IsInfinity(b) || Double.IsInfinity(c))
        {
            throw new ArgumentException();
        }
        
        b = b / a; c = c / a;
        double d = b * b - 4 * c;

        if (d > eps)   //D > 0
        {
            solution = new double[2];
            solution[0] = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
            solution[1] = c / solution[0];
        }
        else if (Math.Abs(d) < eps)   //D = 0
        {
            solution = new double[1];
            solution[0] = -b / 2;
        }
        else    //D < 0
        {
            solution = new double[0];
        }

        return solution;
    }
}
