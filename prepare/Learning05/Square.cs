class Square : Shape
{
    private double _side;

    public Square(string color, double side, string shape = "Square")
        : base(color, shape)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    public override string Description()
    {
        return $" a side of {_side} ";
    }
}
