using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
public abstract class Shape
{
    #region Properties and Fields

    public ShapeColor Color { get; set; }

    public string Name
    {
        get { return this.name; }

        internal set
        {
            Debug.Assert(condition: !String.IsNullOrWhiteSpace(value));

            this.name = value;
        }
    }

    private string name;

    #endregion

    #region Constructors

    public Shape(string name)
    {
        this.Name = name;
    }

    #endregion

    #region Methods

    public virtual string GetDescription()
    {
        return String.Format("{0} of color {1}", this.Name, this.Color);
    }

    public abstract double GetArea();

    #endregion
}