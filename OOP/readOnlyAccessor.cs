using System;
					
public class Program
{
	public static void Main()
	{
		
		//System.Threading.Thread.Sleep(3000); => thread sleep
		
		ReadOnlyAccessor ROA = new ReadOnlyAccessor();
		Console.WriteLine(ROA.str); // "Mirza"
		
		// because we didn't add set accessor we can't modify string name
		
		// ROA.str = "Amar"; => property is readonly
		
	}
	
	
}

public class ReadOnlyAccessor{

	string name = "Mirza";
	
	public string str{ get { return name; } }

}