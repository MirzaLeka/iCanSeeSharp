using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			// how we initialize Struct
			PetStruct dog;
			dog.legs = 4;
			dog.name = "Cuko";
			dog.type = PetType.Dog;
			dog.hasFur = true;

			// to pass a struct into method parameeter we ne do to initialize it like an object
			// PetStruct dog = new PetStruct();

			Console.WriteLine(dog.legs + " " + dog.type);

			// for class we need to create an object
			PetClass duck = new PetClass();
			duck.legs = 2;
			duck.name = "Daffy duck";
			duck.type = PetType.Duck;
			duck.hasFur = false;

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
