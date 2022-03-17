namespace ZsutPw.Patterns.CSharp
{l;ll;l
  using System;
  using System.Diagnostics;

  public class Testcase
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
