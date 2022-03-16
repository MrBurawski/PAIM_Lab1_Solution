public partial class ShapeRepository : IShapeRepository
{
    public Shape[] Find(ShapeColor color)
    {
        IList<Shape> foundShapes = shapes.Where(s => s.Color == color).ToList();

        return foundShapes.ToArray();
    }
}
