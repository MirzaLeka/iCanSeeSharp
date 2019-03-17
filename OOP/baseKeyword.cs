using System;
					
public class SonClass : FatherClass
{
	string favLanguage;

	public static void Main()
	{
		SonClass son = new SonClass();
		son.name = "Mirza";
		son.age = 24;
		Console.WriteLine(son.name);
		
		SonClass sonny = new SonClass("Mirzly", 24, "JS");
		Console.WriteLine(sonny.getFullName());
		Console.WriteLine(sonny.favLanguage);
		
		
	}
	
	public SonClass() {}
	
	public SonClass(string name, int age, string favLanguage) :base(name, age) {
	this.name = name;
	this.age = age;
	this.favLanguage = favLanguage;
		
	}
	
	
}

public class FatherClass {

	protected string name = "Dad";
	protected int age = 57;
	
	public FatherClass() {}
	
	public FatherClass(string name, int age) {
	this.name = name;
	this.age = age;
	}
	
	protected string getFullName() {
		return this.name;
	}

}