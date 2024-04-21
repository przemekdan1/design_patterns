using System;

namespace Vectors
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Vector2D
            Console.WriteLine("\t\t\t 2D vectors ");
            Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(1, 2);

            Console.WriteLine($"\nModule |v1| = [{v1.GetComponents()[0]},{v1.GetComponents()[1]}] = {v1.Abs()}");
            Console.WriteLine($"Module |v2| = [{v2.GetComponents()[0]},{v2.GetComponents()[1]}] = {v2.Abs()}");

            Console.WriteLine($"\nScalar product of v1 and v2: v1*v2 = {v1.Cdot(v2)}");



            //Inheritance2D
            Console.WriteLine("\n\n\n\t\t\t2D vector inheritance:");

            _2DPolarInheritance v3 = new _2DPolarInheritance(5, 9);
            _2DPolarInheritance v4 = new _2DPolarInheritance(1, 2);

            Console.WriteLine($"\nModule |v3| = [{v3.GetComponents()[0]},{v3.GetComponents()[1]}] = {v3.Abs()}");
            Console.WriteLine($"Module |v4| = [{v4.GetComponents()[0]},{v4.GetComponents()[1]}] = {v4.Abs()}");

            Console.WriteLine($"\nScalar product of v1 and v2: v3*v4 = {v3.Cdot(v4)}");

            Console.WriteLine($"\nPolar coordinates of v3 = [{v3.GetComponents()[0]},{v3.GetComponents()[1]}] = ({Math.Round(v3.Abs(),2)} , {v3.GetAngle()})");
            Console.WriteLine($"Polar coordinates of v4 = [{v4.GetComponents()[0]},{v4.GetComponents()[1]}] = ({Math.Round(v4.Abs(), 2)} , {v4.GetAngle()})");




            //Adapter
            Console.WriteLine("\n\n\n\t\t\t2D vector adapter:");


            Polar2DAdapter vp1 = new Polar2DAdapter(v1);
            Polar2DAdapter vp2 = new Polar2DAdapter(v2);

            Console.WriteLine($"\nModule |vp1| = [{vp1.GetComponents()[0]},{vp1.GetComponents()[1]}] = {vp1.Abs()}");
            Console.WriteLine($"Module |vp2| = [{vp2.GetComponents()[0]},{vp2.GetComponents()[1]}] = {vp2.Abs()}");

            Console.WriteLine($"\nScalar product of v1 and v2: v1*v2 = {vp1.Cdot(vp2)}");

            Console.WriteLine($"\nPolar coordinates of vp1 = [{vp1.GetComponents()[0]},{vp1.GetComponents()[1]}] = ({Math.Round(vp1.Abs(), 2)} , {Math.Round(vp1.GetAngle(),2)})");
            Console.WriteLine($"Polar coordinates of vp2 = [{vp2.GetComponents()[0]},{vp2.GetComponents()[1]}] = ({Math.Round(vp2.Abs(), 2)} , {Math.Round(vp2.GetAngle(),2)})");




            //Inheritance3D
            Console.WriteLine("\n\n\n\t\t\t3D vector inheritance:");


            Vector3DInheritance v3d1 = new Vector3DInheritance(1,2,3);
            Vector3DInheritance v3d2 = new Vector3DInheritance(4,5,6);

            Console.WriteLine($"\nModule |v3d1| = [{v3d1.GetComponents()[0]},{v3d1.GetComponents()[1]},{v3d1.GetComponents()[2]}] = {Math.Round(v3d1.Abs(),2)}");
            Console.WriteLine($"Module |v3d1| = [{v3d2.GetComponents()[0]},{v3d2.GetComponents()[1]},{v3d2.GetComponents()[2]}] = {Math.Round(v3d2.Abs(), 2)}");

            Console.WriteLine($"\nScalar product of v3d1*v3d2 = {v3d1.Cdot(v3d2)}");

            Vector3DInheritance v3d3 = v3d1.Cross(v3d2);
            Console.WriteLine($"\nCross v3d1 x v3d2: [{v3d1.GetComponents()[0]},{v3d1.GetComponents()[1]},{v3d1.GetComponents()[2]}] x [{v3d2.GetComponents()[0]},{v3d2.GetComponents()[1]},{v3d2.GetComponents()[2]}] = [{v3d3.GetComponents()[0]},{v3d3.GetComponents()[1]},{v3d3.GetComponents()[2]}]");



            //Decorator3D
            Console.WriteLine("\n\n\n\t\t\t3D vector decorator:");

            Vector3DDecorator v3dd1 = new Vector3DDecorator(v3d1);
            Vector3DDecorator v3dd2 = new Vector3DDecorator(v3d2);

            Console.WriteLine($"\nCdot of v3dd1*v3dd2 = {v3dd1.Cdot(v3dd2)}");
            Console.WriteLine($"Cdot of v3dd1*v3d2 = {v3dd1.Cdot(v3d2)}");


            Console.WriteLine();
            Vector3DDecorator v3dd3 = new Vector3DDecorator(v3dd1.Cross(v1));
            Console.WriteLine($"Cross v3dd1 x v1: [{v3dd1.GetComponents()[0]},{v3dd1.GetComponents()[1]},{v3dd1.GetComponents()[2]}] x [{v1.GetComponents()[0]},{v1.GetComponents()[1]},0] = [{v3dd3.GetComponents()[0]},{v3dd3.GetComponents()[1]},{v3dd3.GetComponents()[2]}]");

            Console.WriteLine();
            Vector3DDecorator v3dd4 = new Vector3DDecorator(v3dd1.Cross(v3d2));
            Console.WriteLine($"Cross v3dd1 x v3d2: [{v3dd1.GetComponents()[0]},{v3dd1.GetComponents()[1]},{v3dd1.GetComponents()[2]}] x [{v3d2.GetComponents()[0]},{v3d2.GetComponents()[1]},{v3d2.GetComponents()[2]}] = [{v3dd4.GetComponents()[0]},{v3dd4.GetComponents()[1]},{v3dd4.GetComponents()[2]}]");
        }

    }
}

