using System;

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
