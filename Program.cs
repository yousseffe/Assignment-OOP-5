using Assignment_OOP_5._3DPoint;
using Assignment_OOP_5;
using Assignment_OOP_5.maths;
namespace Assignment_OOP_5
{
    internal class Program
    {
        static bool ValidateInput(string[] input, out int x, out int y, out int z)
        {
            x = y = z = 0;
            if (input.Length != 3)
            {
                return false;
            }

            return int.TryParse(input[0], out x) && int.TryParse(input[1], out y) && int.TryParse(input[2], out z);
        }
        static void Main(string[] args)
        {
            #region 3DPoint
            /*Console.WriteLine("Enter coordinates for point P1 (X Y Z): ");
                var input1 = Console.ReadLine().Split();
                if (ValidateInput(input1, out int x1, out int y1, out int z1))
                {
                    Point3D P1 = new Point3D(x1, y1, z1);

                    Console.WriteLine("Enter coordinates for point P2 (X Y Z): ");
                    var input2 = Console.ReadLine().Split();
                    if (ValidateInput(input2, out int x2, out int y2, out int z2))
                    {
                        Point3D P2 = new Point3D(x2, y2, z2);

                        Console.WriteLine(P1.ToString());
                        Console.WriteLine(P2.ToString());

                        if (P1 == P2)
                        {
                            Console.WriteLine("P1 is equal to P2");
                        }
                        else
                        {
                            Console.WriteLine("P1 is not equal to P2");
                        }

                        Point3D[] points = { P1, P2, new Point3D(5, 5, 5), new Point3D(1, 2, 3) };
                        Array.Sort(points);

                        Console.WriteLine("Sorted Points:");
                        foreach (Point3D point in points)
                        {
                            Console.WriteLine(point.ToString());
                        }

                        Point3D P3 = (Point3D)P1.Clone();
                        Console.WriteLine($"Cloned Point: {P3.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for point P2.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for point P1.");
                }*/
            #endregion
            
            Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {Maths.Divide(10, 5)}");
        }
    }
}
