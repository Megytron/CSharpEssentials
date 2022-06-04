using System;
					
public class Program
{
	public GameStates gameStates;
	
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.BadPowerUp;
		gameStates.CheckState();
	}
}

public class GameStates {
	
	public enum States {
		GoodPowerUp,
		BadPowerUp
	}
	
	public States currentState = States.GoodPowerUp;
	
	public void CheckState () {
		switch (currentState) {
			case States.BadPowerUp:
				Console.WriteLine("YOU DIED");
				break;
			case States.GoodPowerUp:
				Console.WriteLine("LEVEL UP");
				break;
			
		}
	}
}
