using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] arr = { 1, 2, 3, 4, 5 };
			Console.WriteLine(arr[0]);

			int[] brr = arr;

			brr[0] = 5;
			Console.WriteLine(arr[0]);
			Console.WriteLine(brr[0]); // reference type!

			// multiDimArray

			int[,] doubleArr = new int[2, 3]; // number of elements per each column

			// each {} is a row. elements inside are columns.
			int[,] initializeDoubleArr = { { 1, 2, 3 }, { 4, 5, 6 } };

			// row index 1, column index 2
			Console.WriteLine(initializeDoubleArr[1, 2]);  // output: 6

			// Copy elements from one array to another

			int[] original = { 1, 2, 3, 4, 5 };

			int[] copied = new int[5];

			// Not recommended way, but it worked this time
			foreach(var i in original)
			{
				copied[i - 1] = i;
			}

	/*		for(var i = 0; i < original.Length; i++)
			{
				copied[i] = original[i];
			}
			*/
			Console.WriteLine("--------- New Array ------------");

			for (var i = 0; i < copied.Length; i++)
			{
				Console.Write(copied[i] + " ");
			}


			// Collections

			List<string> listOfStrings = new List<string>(); // no need to define max number of items
			listOfStrings.Add("First string"); // adds item to the list to index 0
			listOfStrings.Add("second string"); // adds new item, right after the previous item
			listOfStrings.Insert(0, "Inserted String"); // adds new item to index where we want it to and pushes the other items below it

			listOfStrings.Remove("first string"); // removes this item by it's value
			listOfStrings.RemoveAt(0); // removes item that matches the index we pass

			listOfStrings.Add("third string"); 
			listOfStrings.Add("fourth string"); 

			listOfStrings.Sort(); // sorts list
			listOfStrings.Reverse(); // reverses list
			Console.WriteLine(listOfStrings.Count); // counts number of elements in the list

			// loop through. can be done with foreach as well
			for(var i = 0; i < listOfStrings.Count; i++)
			{
				Console.Write(listOfStrings[i] + " ");
			}


			// Dictionary => collection type with Key and a Value (like Map in JS)

			Dictionary<string, string> firstAndLastNames = new Dictionary<string, string>();
			firstAndLastNames.Add("Will", "Smith");
			firstAndLastNames.Add("James", "Bond");

		//	Console.WriteLine("The name is" + firstAndLastNames[0]); we cant reference itemes by indexes

			// instead we reference them by keys
			Console.WriteLine("The last name is " + firstAndLastNames["James"]); // and this will print the value of that key

			firstAndLastNames.Remove("Will"); // again we pass the key to remove an item in Dictionary

			/* Foreach example 
			foreach (var money in myMoney) {
				Console.WriteLine("Amount is {0} and type is {1}", money.amount, money.type);
			}
			 */


			// LINQ => query language that can be used to find elements within the lists 
			// we can use a standard query or an arrow function

			/* Syntax
			 List<someList> results = from x in list
									 where x = filter
									 select x;
		    */

			List<PetClass> pets = new List<PetClass>();
			// we'll store instnaces of this class into our list

			// PetClass pet1 = new PetClass(); we can do this, but it would take forever for us to create new object
			// pets.Add(pet1); every time, give it props and add that object to the list. There is a shorter way:

			pets.Add(new PetClass { hasFur = false, legs = 2, name = "Donald", type = PetType.Duck });
			pets.Add(new PetClass { hasFur = false, legs = 2, name = "Daffy", type = PetType.Duck });
			pets.Add(new PetClass { hasFur = true, legs = 4, name = "Scooby Doo", type = PetType.Dog });

			// now we can query the list we just created. we'll create a new list, results

			List<PetClass> results = (from p in pets // for each pet in pets list
									  where p.type == PetType.Duck // return where pet.propoperty = some value
									  select p) // select p (meaning return that p)
									 .ToList(); // and create a list out of it

			// print out all elements in results list
			foreach(var i in results)
			{
				Console.WriteLine("Name: " + i.name + ", type: " + i.type );
			}

			// The same query could be written using Lambda query (arrow function)

			results = pets.Where(p => p.type == PetType.Duck).ToList();

			// these two queries are exactly the same, 
			// but for smaller queries, where we return a single item, we should use Lambda
			// otherwise standard LINQ is a better option

			foreach (var i in results)
			{
				Console.WriteLine("Name: " + i.name + ", type: " + i.type);
			}

			Console.ReadLine();

		}


	}
}

struct PetStruct
{
	public int legs;
	public PetType type;
	public string name;
	public bool hasFur;
}

class PetClass
{
	public int legs;
	public PetType type;
	public string name;
	public bool hasFur;
}

enum PetType
{
	Dog, 
	Duck
}
