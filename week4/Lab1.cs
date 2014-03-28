using System;

namespace divide
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

			Console.Write ("Enter the operation(+,-,*,/,% are allowed)");
			string operator1 = Console.ReadLine ();
			if (operator1 == "+") {
				Console.Write ("계산 결과: {0}", num3 + num4);
			}
			else if (operator1 == "-") {
				Console.WriteLine ("계산 결과: {0}", num3 - num4);
			} 
			else if (operator1 == "*") {
				Console.WriteLine ("계산 결과: {0}", num3 * num4);
			} 
			else if (operator1 == "/") {
				Console.WriteLine ("계산 결과: {0}", num3 / num4);
			} 
			else if (operator1 == "%") {
				Console.WriteLine ("계산 결과: {0}", num3 % num4);
			} 
			else {
				Console.WriteLine ("You entered {0}, Only +,-,*/,% are allowed", operator1);
			}
		}
	}
}
