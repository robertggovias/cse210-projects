class Shape{
    private string _color;
    protected string _shape;
    public Shape (string color, string shape){
        _color = color;
        _shape = shape;
    }

    public string GetColor() {
        return _color;
    }

    public string GetShape(){
        return _shape;
    }

    public void  SetColor(string color) {
        _color = color;
    }
    public virtual double GetArea(){
        return -1;           
    }
    public virtual string Description(){
        return "";
    }
}

