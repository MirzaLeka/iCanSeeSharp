using System;
					
public class Program
{
	public static void Main()
	{
		var array = new int[] {1, 2, 3};
		
		var enumerator = array.GetEnumerator();
		while (enumerator.MoveNext()) {
			Console.WriteLine(enumerator.Current);
		}
	}
}

// this works exactly like foreach
// arrays inhertit Enumerator
// Enumerator comes with 3 properties, Current, MoveNext() and Reset()
// While there are elmements in an array, move to next and print current