using System;

class RadiusofCircle
{
	static void Main (string [] args)
	{
		Console.Write ("Enter the radius of the circle: ");
		int r = Int32.Parse (Console.ReadLine());
		
		Console.WriteLine ("The perimeter of the circle is {0:0.0000} ", 2 * Math.PI * r);
		Console.WriteLine ("The area of the circle is {0:0.0000} ", Math.PI * r * r);
		Console.ReadKey();
	}
}