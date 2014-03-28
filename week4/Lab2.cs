using System;

namespace Switch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number : ");
			string num1 = Console.ReadLine ();
			Console.Write ("Enter the first number : ");
			string num2 = Console.ReadLine ();

			int num3 = int.Parse (num1);
			int num4 = int.Parse (num2);

			Console.Write ("Enter the operation(+, -, *, /,% are allowed)");

			string operator1 = Console.ReadLine ();

			switch (operator1){
			case "+":
				Console.Write ("계산 결과: {0}", num3 + num4);
				break;
			case "-": 
				Console.WriteLine ("계산 결과: {0}", num3 - num4);
				break;
			case "*": 
				Console.WriteLine ("계산 결과: {0}", num3 * num4);
				break;
			case "/": 
				Console.WriteLine ("계산 결과: {0}", num3 / num4);
				break;
			case "%": 
				Console.WriteLine ("계산 결과: {0}", num3 % num4);
				break;
	
			default: 
				Console.WriteLine ("You entered {0}, Only +,-,*,/,% are allowed", operator1);
			break;}
		}
	}
}
