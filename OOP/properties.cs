using System;
					
public class Program
{

	public static void Main()
	{
		Properties prop = new Properties();
		
		var output = prop.sum(prop.num1 = 9, prop.num2 = 5); // default values
		Console.WriteLine(output);
		
	}
}

class Properties{
 int _number1 = 0; // no accessor == private
 int _number2 = 0; 
	
	public int num1 { get { return _number1; } set { _number1 = value; } }
	public int num2 { 
		get { 
			return _number2;
			}
		set {
			_number2 = value;
		} 
	}
	
	public int sum(int a, int b) {
		return a+b;
	}

}