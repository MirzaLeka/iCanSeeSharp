using System;

// when we don't write any logic we can just use auto-implementation
// variables are object properties
// get and set are accessors

public class Person
{
  private int age = 19; // property 
  public int Age{get; set;} // autoimplementation
public static void Main(string[] args)
{
  Person p = new Person();
  p.Age = 100;
  Console.WriteLine(p.Age);
 }
}

// but we can also create some logic 
// if private int age is above above 18 it will be set to 100, otherwise it will remain 1

public class Person
{
  private int age = 1;
  public int Age
  {
    get { return age; }
   set {
   	 if ( age > 18) {
	   age = value;
	 }
       }

  }

public static void Main(string[] args)
{
  Person p = new Person();
  p.Age = 100;
  Console.WriteLine(p.Age);
 }
}

// either get or set can be private, but not both
// we can also either set one or the other or both
