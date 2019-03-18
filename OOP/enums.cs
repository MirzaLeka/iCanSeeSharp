using System;
					
public class Program
{
	
	enum names {
	Ermin,
	Sinan,
	Mirza = 24
	}
	
	public static void Main()
	{
		Console.WriteLine("My name is " + names.Mirza + " and I am " + (int)names.Mirza + " years old.");
	}
}