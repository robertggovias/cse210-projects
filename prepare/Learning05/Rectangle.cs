class Rectangle : Shape
{
    private double _lengtLongSide;
    private double _lengthShortSide;

    public Rectangle(string color, double longSide, double shortSide, string shape = "Rectangle")
        : base(color, shape)
    {
        _lengtLongSide = longSide;
        _lengthShortSide = shortSide;
    }

    public override double GetArea()
    {
        return _lengthShortSide * _lengtLongSide;
    }

    public override string Description()
    {
        return $" a long side of {_lengtLongSide} and a short side of {_lengthShortSide} ";
    }
}
