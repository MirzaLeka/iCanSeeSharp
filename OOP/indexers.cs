using System;
					
public class Program : IndexerExample
{
	public static void Main()
	{
		Program p = new Program();
		Console.WriteLine(p[0]); // Mirza => as if p is an array
		p[1] = "TM87";
		Console.WriteLine(p[1]); // TM87
		
		// because array is attached to 'this' via Indexer we can directly access array elements
	}
}

public class IndexerExample{
	
	// array of strings
	protected string[] arr = {"Mirza", "Ermin", "Amar"};
	
	// indexer of an array (also type string)
	protected string this [int arrIndex] 
	{ 
		get { return arr[arrIndex]; }
		set { arr[arrIndex] = value; }
	}

}