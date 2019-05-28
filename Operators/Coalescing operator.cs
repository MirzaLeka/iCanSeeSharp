using System;
					
public class Program
{
	public static void Main()
	{
		string s1 = null;
		string s2 = null;
		string s3 = "Mirza";
		
		string final = s1 ?? s2 ?? s3;
		Console.WriteLine(final); // output: "Mirza"

// if s1 is null go with s2, if s2 is null go with s3... till you find not null value
// s1 ?? s2 ?? s3
	}
}