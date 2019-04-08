using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		
	List<Person> person = new List<Person>();
	person.Add(new Person { Name = "Joe", Age = 25 });
	person.Add(new Person { Name = "Nick", Age = 31 });		
	person.Add(new Person { Name = "Mike", Age = 24 });		

	Console.WriteLine("List of people in Person list:");
	foreach(var p in person) {
//	Console.WriteLine($"{p.Name} : {p.Age}"); Not supported :(
	Console.WriteLine(string.Format("{0} : {1}", p.Name, p.Age));
	}	
		
	List<Person> millennials = (from p in person
				where p.Age < 30 
			        select p) 
				.ToList(); 
		
	Console.WriteLine("\nList of millennials in Person list:");
	foreach(var m in millennials) {
	Console.WriteLine(string.Format("{0} : {1}", m.Name, m.Age));
	}	
		
	}
	
}

class Person {
	public string Name { get; set; }
	public int Age { get; set; }
}

