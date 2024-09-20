
class Mat
{
    public double pow(double a, int n)
    {
        for (int i = 1; i < n; i++)
        {
            a = a * n;
        }

        return a;
    }
}

class Function
{
    public double a, b, c, d;
    

    public Function (double aInput)
    {
        a = aInput;
    }
    public Function (double aInput, double bInput)
    {
        a = aInput;
        b = bInput;
    }
    public Function (double aInput, double bInput, double cInput)
    {
        a = aInput;
        b = bInput;
        c = cInput;
    }
    public Function (double aInput, double bInput, double cInput, double dInput)
    {
        a = aInput;
        b = bInput;
        c = cInput;
        d = dInput;
    }

    public double Value(double xInput)
    {
        Mat mat = new Mat();
        double y;
        double x = xInput;

        y = (d*mat.pow(x, 3)) + (c * mat.pow(x, 2)) + (b * x) + a;

        return y;
    }

    public char[,] Plot (int xRange, int yRange)
    {
        char[,] plot = new char[xRange, yRange];

        return plot;
    }
}

class program()
{
    static void Main()
    {
        Function newFuction = new Function(2, 2, 2, 2);
        Console.WriteLine(newFuction.Value(10));
    }
}