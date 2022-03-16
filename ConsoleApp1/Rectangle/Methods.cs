using System.Diagnostics;
public partial class Rectangle : Shape 
{
    public Rectangle(string name, double width, double height) : base(name)
    {
    Debug.Assert(condition: width > 0 && height > 0);

    this.Width = width;
    this.Height = height;
}

public override double GetArea()
{
    return this.Width * this.Height;
}
}