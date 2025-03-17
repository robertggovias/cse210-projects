class Circle : Shape{
    
    private double _radio;
    private double _radioSquared;
    public Circle(string color, double radio,string shape = "Circle") : base(color,shape) {
        _radio = radio;
        _radioSquared = Math.Pow(radio, 2);
     }
     public double pi = Math.PI;
    public override double GetArea()
    {
        return pi * _radioSquared;
    }
       public override string Description(){
        return $" a radio of {_radio} ";
    }

}