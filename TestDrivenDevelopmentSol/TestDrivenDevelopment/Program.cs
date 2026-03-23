
namespace TestDrivenDevelopment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Compass.Rotate(Direction.LEFT, Point.NORTH));
            Console.WriteLine(Compass.Rotate(Direction.LEFT, Point.EAST));
            Console.WriteLine(Compass.Rotate(Direction.LEFT, Point.SOUTH));
            Console.WriteLine(Compass.Rotate(Direction.LEFT, Point.WEST));
        }
    }
}