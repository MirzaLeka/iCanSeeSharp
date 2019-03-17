using System;
					
public class Subtract : Program
{	
		protected override int calculate(int a, int b) {
		return a-b;
		} 
}

public class Sum : Program {

		protected override int calculate(int a, int b) {
		return a+b;
		}
		
}

public class Program{

	public static void Main()
	{
	
		
	Program sum = new Sum();
	Console.WriteLine(sum.calculate(5,2));
	
	Program sub = new Subtract();
	Console.WriteLine(sub.calculate(5,2));
		
		
	}
	
	 protected virtual int calculate(int a, int b) {
	 	return a+b;
	 }
	
}