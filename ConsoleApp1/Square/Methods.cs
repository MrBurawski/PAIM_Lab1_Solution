
using System.Diagnostics;
//no change
public partial class Square : Shape
{
    public Square(string name, double size) : base(name)
    {
        Debug.Assert(condition: size > 0);

        this.Size = size;
    }

    public override double GetArea()
    {
        return this.Size * this.Size;
    }
}
