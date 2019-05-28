using System;
					
public class Swap
{
	public static void Main()
	{
	
		int m = 5;
		int n = 4;
		
		Console.WriteLine("m is " + m + ", n is " + n);
		// before: m is 5, n is 4

		m = m^n;
		n = n^m;
		m = m^n;
		
		Console.WriteLine("m is " + m + ", n is " + n);
		// after: m is 4, n is 5
	}
}
