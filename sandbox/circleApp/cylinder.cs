class Cylinder
{
    public Cirlce _circle;

    public double _height;

    public double GetCylinderVolume()
    {
        return _circle.GetArea() * _height;
    }
}