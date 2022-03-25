using System;
public class FIZZBZ{
public static void Main()
{
	int myInt;
	Console.WriteLine("Enter Numbers or Q to Quit");
	string inp = Console.ReadLine();
	while (inp != "Q")
	{
			if (int.TryParse(inp, out myInt))
			{
				
				if (myInt % 15 == 0)
					Console.Write("FizzBuzz" + " ");
			    else if (myInt % 3 == 0)	
					Console.Write("Fizz" + " ");
				else if (myInt % 5 == 0)											
					Console.Write("Buzz" + " ");
				else {
					Console.Write("Divided " + myInt + " by 3 ");	
					Console.WriteLine();
					Console.Write("Divided " + myInt + " by 5 ");	
				}
				Console.WriteLine();
			}
			else
			{
				Console.Write("Invalid item");
				Console.WriteLine();
			}
		Console.WriteLine("Enter Numbers or Q to Quit");
		inp = Console.ReadLine();
	}
		 
}
}

