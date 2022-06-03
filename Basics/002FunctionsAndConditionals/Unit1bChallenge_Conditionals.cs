using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(13, 11);
		myOperator.DoMath(25, 69);
		myOperator.DoMath(420, 76);
		myOperator.Compare(14, 80);
		myOperator.Compare(9, 3);
		myOperator.CheckPassword("Nikkip143");
		myOperator.CheckPassword("RavenHarley456321");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value < value2) {
			Console.WriteLine("True, the first is less than.");
		} else {
			Console.WriteLine("False, the second is less than.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "RavenHarley456321") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
}
