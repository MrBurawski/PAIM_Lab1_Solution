namespace ZsutPw.Patterns.CSharp
{
  using System;
  using System.Diagnostics;
  using System.Collections.Generic;
  using System.Linq;

  public enum ShapeColor
  {
    Red,
    Blue,
    Green
  }

  public abstract class Shape
  {
        #region Properties and Fields
        public ShapeColor Color { get; set; }

    public string Name
    {
      get { return this.name; }

      internal set
      {
        Debug.Assert( condition: !String.IsNullOrWhiteSpace( value ) );

        this.name = value;
      }
    }

    private string name;

    #endregion

    #region Constructors

    public Shape( string name )
    {
      this.Name = name;
    }

    #endregion

    #region Methods

    public virtual string GetDescription( )
    {
      return String.Format( "{0} of color {1}", this.Name, this.Color );
    }

    public abstract double GetArea( );

    #endregion
  }

  public class Square : Shape
  {
    public double Size { get; private set; }

    public Square(  string name, double size ) : base( name )
    {
      Debug.Assert( condition: size > 0 );

      this.Size = size;
    }

    public override double GetArea( )
    {
      return this.Size * this.Size;
    }
  }

  public class Rectangle : Shape
  {
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle( string name, double width, double height ) : base( name )
    {
      Debug.Assert( condition: width > 0 && height > 0 );

      this.Width = width;
      this.Height = height;
    }

    public override double GetArea( )
    {
      return this.Width * this.Height;
    }
  }

  public struct Point
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Point( int x, int y )
    {
      (this.X, this.Y) = (x, y);
    }
  }

  public interface IShapeRepository
  {
    Shape[ ] Find( ShapeColor color );
  }

  public class ShapeRepository : IShapeRepository
  {
    private readonly Shape[ ] shapes = new Shape[ ]
    {
      new Square( "kwadrat1", 1.0 ) { Color = ShapeColor.Green },
      new Rectangle( "prostokat1", 2.0, 1.0 ) { Color = ShapeColor.Red },
      new Rectangle( "prostokat2", 1.0, 2.0 ) { Color = ShapeColor.Green }
    };

    public Shape[ ] Find( ShapeColor color )
    {
      IList<Shape> foundShapes = shapes.Where( s => s.Color == color ).ToList( );

      return foundShapes.ToArray( );
    }
  }

  public class Program1
  {
    public static void Main( string[ ] args )
        {
      IShapeRepository shapeRepository = new ShapeRepository( ) as IShapeRepository;

      Debug.Assert( condition: shapeRepository != null );

      foreach( Shape shape in shapeRepository.Find( ShapeColor.Green ) )
      {
        string shapeDescription = shape.GetDescription( );
        double shapeArea = shape.GetArea( );

        Console.WriteLine( "shape description = {0}; shape area = {1}", shapeDescription, shapeArea );
      }
      Console.ReadLine( );
    }
  }
}
