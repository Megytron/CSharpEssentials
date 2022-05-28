//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{
	public Element Water;
	public Element Earth;
  public Element Fire;
  public Element Air;
	
	public void Main()
	{
		Water = new Element();
		Earth = new Element();
    Fire = new Element();
    Air = new Element();
		
		Water.Healing = 5;
		Water.Power = 4;
    Water.Damage = 2;
    Water.Swiftness = 3;
		
		Earth.Healing = 3;
		Earth.Power = 5;
    Earth.Damage = 4;
    Earth.Swiftness = 2;
    
    Fire.Healing = 0;
    Fire.Power = 4;
    Fire.Damage = 5;
    Fire.Swiftness = 3;
    
    Air.Healing = 3;
    Air.Power = 4;
    Air.Damage = 2;
    Air.Swiftness = 5;
		
		Console.WriteLine(Water.Healing);
		Console.WriteLine(Water.Power);
    Console.WriteLine(Water.Damage);
    Console.WriteLine(Water.Swiftness);
		
		Console.WriteLine(Earth.Healing);
		Console.WriteLine(Earth.Power);
    Console.WriteLine(Earth.Damage);
    Console.WriteLine(Earth.Swiftness);
    
    Console.WriteLine(Fire.Healing);
    Console.WriteLine(Fire.Power);
    Console.WriteLine(Fire.Damage);
    Console.WriteLine(Fire.Swiftness);
    
    Console.WriteLine(Air.Healing);
    Console.WriteLine(Air.Power);
    Console.WriteLine(Air.Damage);
    Console.WriteLine(Air.Swiftness);
	}
}

public class Element {
	public int Healing;
	public int Power;
  public int Damage;
  public int Swiftness;
}
