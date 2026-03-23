using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class Compass
    {
        public Point Point { get; private set; }

        public Compass()
        {
        }

        public static Point Rotate(Direction direction, Point point)
        {
            List<Point> points = new() { Point.NORTH, Point.EAST, Point.SOUTH, Point.WEST };
            var pointIndex = points.FindIndex(0, points.Count - 1, i => i.Equals(point));

            switch (direction)
            {
                case Direction.RIGHT:
                    if (pointIndex < 0)
                    {
                        throw new InvalidDataException("This Point does not exist");
                    }
                    else if (pointIndex > points.Count - 1)
                    {
                        return points[0];
                    }
                    else
                    {
                        return points[pointIndex + 1];
                    }

                case Direction.LEFT:
                    if (pointIndex < 0)
                    {
                        throw new InvalidDataException("This Point does not exist");
                    }
                    else if (pointIndex < 1)
                    {
                        return points[points.Count - 1];
                    }
                    else
                    {
                        return points[pointIndex - 1];
                    }
            }
            throw new InvalidDataException("Invalid Direction or Point value");
        }
    }
}
