public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string result = _numerator + "/" + _denominator;
        return result;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }

    // public int GetTop()
    // {
    //     return _numerator;
    // }
    // public int GetBottom()
    // {
    //     return _denominator;
    // }
    // public void SetTop(int top)
    // {
    //     _numerator = top;
    // } 
    // public void SetBottom(int bottom)
    // {
    //     _denominator = bottom;
    // }
}