class Rectangle : Shape
{
    private double _width;
    private double _length;
    public Rectangle(string _color, double side1, double side2) : base(_color)
    {
        _width = side1;
        _length = side2;
    }

    public override double GetArea()
    {
        return _width * _length;   
    }

}