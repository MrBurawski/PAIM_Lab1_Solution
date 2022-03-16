using System;

#region Methods

public virtual string GetDescription()
{
    return String.Format("{0} of color {1}", this.Name, this.Color);
}

public abstract double GetArea();

#endregion
