
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
public class Square : Shape
{
    public double Size { get; private set; }

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
