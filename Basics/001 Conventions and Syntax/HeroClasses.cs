//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero WildCard;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		WildCard = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.stamina = 10;
		heroOne.dexterity = 1;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.stamina = 5;
		heroTwo.dexterity = 10;
		
		heroThree.health = 1;
		heroThree.powerLevel = 10;
		heroThree.stamina = 2;
		heroThree.dexterity = 5;
		
		WildCard.health = 1000;
		WildCard.powerLevel = 1000;
		WildCard.stamina = 1000;
		WildCard.dexterity = 1000;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.stamina);
		Console.WriteLine(heroOne.dexterity);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.stamina);
		Console.WriteLine(heroTwo.dexterity);
		
		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.stamina);
		Console.WriteLine(heroThree.dexterity);
		
		Console.WriteLine(WildCard.health);
		Console.WriteLine(WildCard.powerLevel);
		Console.WriteLine(WildCard.stamina);
		Console.WriteLine(WildCard.dexterity);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int stamina;
	public int dexterity;
}
