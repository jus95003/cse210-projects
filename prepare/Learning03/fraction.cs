public class FractionWriter
{
    private int _numerator;
    private int _denominator;

    public FractionWriter()
    {
        _numerator = 1;

        _denominator = 1;
    }

    public FractionWriter(int numerator)
    {
        _numerator = numerator;

        _denominator = 1;
    }

    public FractionWriter(int numerator, int denominator)
    {
        _numerator = numerator;

        _denominator = denominator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        string _fraction = _numerator + "/" + _denominator;
        return _fraction;
    }

    public double GetDecimalValue()
    {
        double _decimal = (double)_numerator / _denominator;
        return _decimal;
    }
}